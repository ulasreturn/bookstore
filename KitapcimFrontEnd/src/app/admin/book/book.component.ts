import { Component, OnInit } from '@angular/core';
import { Router } from "@angular/router";
import { ApiService } from "src/core/services/api/api.service";
import { Books } from 'src/core/models/books.model';
import { ConfirmationService, MessageService } from 'primeng/api';
import { BookRequest } from 'src/core/models/request/books-request.model';
import { ResponseStatus } from 'src/core/models/response/base-response.model';

@Component({
  selector: 'app-book',
  templateUrl: './book.component.html',
  styleUrls: ['./book.component.css'],
  providers: [MessageService, ConfirmationService]
})
export class BookComponent implements OnInit {
  public booksRequest: BookRequest = <BookRequest>{}

  booksAddDialog: boolean = false;
  booksEditDialog: boolean = false;
  openModel: boolean = false;

  BooksToEdit: Books | null = null;

  filteredBooks: Books[] = [];
  public searchBooksName: string = '';

  constructor(private readonly apiService: ApiService,
    private router: Router,
    private messageService: MessageService,
    private confirmationService: ConfirmationService,

  ) { }


  searchbooks(searchKey: string) {
    this.filteredBooks = this.books.filter((book) => {
      const targetKey = book.id + ' ' + book.bookName;
      return targetKey.includes(searchKey);
    });
  }

  books: Books[] = [];
  ngOnInit() {
    this.refresh()
  }
  //bu kod bize evlerin ekrana gelmesini sağlayan kod yapısı...
  refresh() {
    this.apiService.getAllEntities(Books).subscribe((response) => {
      this.books = response.data;
      this.filteredBooks=this.books;
      console.log(this.books)
    });
    //console.log(this.users)

  }


  


  onCreate(entity: BookRequest) {
    this.createEntity<BookRequest>(entity, 'Books').then(response => {
      if (response?.status == ResponseStatus.Ok) {
        this.refresh();
        this.messageService.add({ severity: 'success', summary: 'Başarılı', detail: 'Kitap ekleme başarılı', life: 3000 });
      }
    });
  }

  createEntity<TEntity>(entity: TEntity, entityType: string) {
    return this.apiService.createEntity<TEntity>(entity, entityType);
  }


  selectedFiles: File[] = [];

  onFileChange(event: any) {
    const fileList: FileList = event.target.files;
    for (let i = 0; i < fileList.length; i++) {
      this.selectedFiles.push(fileList[i]);
    }
  }

  deleteFile(file: File) {
    const index = this.selectedFiles.indexOf(file);
    if (index > -1) {
      this.selectedFiles.splice(index, 1);
    }
  }

  addNewBook() {
    this.booksAddDialog = true;
  }

  deleteBook(id: number) {
    this.delete(id).then(response => {
      if (response?.status == ResponseStatus.Ok) {
        this.refresh();
        this.messageService.add({ severity: 'success', summary: 'Başarılı', detail: 'Kitap başarı ile silindi', life: 3000 });
      }
    })
  }

  delete(id: number) {
    return this.apiService.deleteEntity(id, Books);
  }

  // editHouse() {
  //   this.houseEditDialog = true;
  // }

  openEditDialog(id: number) {
    this.apiService.getEntityById<Books>(id, Books).then((response) => {
      if (response && response.data) {
        this.booksEditDialog = true;
        this.BooksToEdit = response.data;
         // API'den alınan aracı carToEdit değişkenine atıyoruz
      } else {
        console.error('Kitap bulunamadı veya alınırken bir hata oluştu.');
      }
    }).catch((error) => {
      console.error('Kitap alınırken bir hata oluştu:', error);
    });
  }

  onUpdate(id: number, updatedBook: Books) {
    this.update(id, updatedBook).then(response => {
      if (response?.status == ResponseStatus.Ok) {
        this.refresh();
        this.messageService.add({ severity: 'success', summary: 'Başarılı', detail: 'Kitap güncelleme başarılı', life: 3000 });
        this.hideDialog(); // Güncelleme işlemi tamamlandığında dialogu gizle
      }
    }).catch((error) => {
      console.error('Araç güncellenirken bir hata oluştu:', error);
    });
  }

  update(id: number, updatedBook: Books) {
    return this.apiService.updateEntity(id, updatedBook, Books);
  }

  hideDialog() {

  }

  closeModal() {
    this.openModel = false;
  }

  modelOpen() {
    this.openModel = true;
  }

}