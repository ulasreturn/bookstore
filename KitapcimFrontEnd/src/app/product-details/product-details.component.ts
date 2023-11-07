import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CommentRequest } from 'src/core/models/request/comment-request.model';
import { ApiService } from 'src/core/services/api/api.service';
import { ActivatedRoute } from '@angular/router';
import { Comment } from 'src/core/models/comment.model';
import { AuthService } from 'src/core/services/auth/auth.service';
import { MessageService, ConfirmationService } from 'primeng/api';
import { ResponseStatus } from 'src/core/models/response/base-response.model';
import { User } from 'src/core/models/user.model';
import { PaginationInstance } from 'ngx-pagination';
import { Books } from 'src/core/models/books.model';
import { BookRequest } from 'src/core/models/request/books-request.model';
@Component({
  selector: 'app-product-details',
  templateUrl: './product-details.component.html',
  styleUrls: ['./product-details.component.css'],
  providers: [MessageService, ConfirmationService]
})
export class ProductDetailsComponent implements OnInit {
  public config: PaginationInstance = {
    // Yorumları sayfa şeklinde çağırdım.
    id: 'advanced',
    itemsPerPage: 3, // Bir sayfada 3 yorum
    currentPage: 1,
  };

  onPageChange(event: number) {
    this.config.currentPage = event;
  }

  public commentRequest: CommentRequest = {
    commentDate: new Date()
  };

  comments: Comment[] = [];
  loggedInUserId?: number | null = null; 
  currentUser: User | null = null;
  isLoggedIn = false;
  user: User | null = null;
  bookId: any[] | null = null;
  filteredComment: Comment[] = [];
  books: any[] | null = null;
  bookDetails: Books[] = [];// Tüm kitapları içeren dizi
  selectedBook: Books | undefined; // 
  defaultImageUrl: string = 'https://upload.wikimedia.org/wikipedia/commons/thumb/6/65/No-Image-Placeholder.svg/1665px-No-Image-Placeholder.svg.png';

  constructor(
    private apiService: ApiService,
    private readonly authService: AuthService,
    private messageService: MessageService,
    private confirmationService: ConfirmationService,
    private route: ActivatedRoute,
    private http: HttpClient
  ) {}

  ngOnInit() {
    // Kullanıcı bilgileri için işlemler
    this.authService.currentUser.subscribe((user: User | null) => {
      this.user = user;
    });
    this.authService.currentUser.subscribe((user) => {
      this.currentUser = user;
      this.isLoggedIn = user !== null;
    });
   this.refresh();
   // Paramsdan gelen book bilgilerini ekrana yansıttım.
   this.route.params.subscribe(params => {
    const bookId = params['bookId'];
    if (bookId !== null) {
      this.apiService.getBookInfo(bookId).subscribe((data: any) => {
        console.log('API Yanıtı:', data); // Yanıtı konsola yazdırın
        this.selectedBook=data.data;// Seçilen kitabı bul
        console.log('control',  this.selectedBook); // Seçilen kitabı kontrol etmek için konsola yazdırın
       
      });
    }
  });
  


 

  
    // Params'dan gelen bookId'sini this.commentRequest.booksId'ye aktardım
    this.route.paramMap.subscribe((params) => {
      const bookId = params.get('bookId');
      if (bookId !== null) {
        
          const bookIdNumber = +bookId; // bookId'yi sayıya çevir
          this.commentRequest.booksId = bookIdNumber;
          this.loadBookDetails(bookIdNumber);
          
          console.log('Deneme', this.commentRequest.booksId); 
      } else {
        
      }
  });
  
  }
  
  refresh(){
    //Giriş yapan kullanıcı bilgisini loggedInUserId'de tutuyorum. Bu yorum eklemede veriyi gizli bir input olan commentRequest.userId'ye aktarıyorum. 
    const user = this.authService.getCurrentUser();
    if (user) {
      this.loggedInUserId = user.id ?? null;
      
        if (this.loggedInUserId !== null && this.loggedInUserId !== undefined) {
          this.commentRequest.userId = this.loggedInUserId;
        } else {
        
        }
      

      console.log('Kullanıcı Kimliği:', this.loggedInUserId);
    
    }
  }

  loadBookDetails(bookId:Number) {
    // bookId'yi kullanarak ilgili kitaba ait bilgileri API'dan alabilirsiniz
  
this.apiService.getAllEntitiesComments('Comment/GetAllComments').subscribe((response: any) => {
  const comments: Comment[] = response.$values;  // Verileri comments dizisine atama işlemi
  this.comments = comments;

  // İlgili bookId'ye sahip yorumları seçmek için bir filtreleme işlemi yapabilirsiniz
  const bookIdToFetch = bookId; // Almak istediğiniz bookId
  this.filteredComment = this.comments.filter(comment => comment.bookId === bookIdToFetch);

  console.log(this.filteredComment);
  console.log("bookıd",bookIdToFetch) 

if (this.books) {
  const selectedBook = this.books.find(book => book.bookId === bookId);

  if (selectedBook) {
    // Kitapın bilgilerini kullanabilirsiniz
    const coverPhoto = selectedBook.coverPhoto;
    const bookName = selectedBook.bookName;
    const price = selectedBook.price;


    // Şimdi bu bilgileri kullanarak istediğiniz işlemleri yapabilirsiniz
    console.log('Kitap Resmi:', coverPhoto);
    console.log('Kitap Adı:', bookName);
    console.log('Fiyat:', price);

  } else {
    // Kitap bulunamadığında ne yapılacağını belirleyin (örneğin bir hata mesajı gösterin)
    console.log('Kitap bulunamadı.');
  }
} else {
  // this.books null ise ne yapılacağını belirleyin (örneğin bir hata mesajı gösterin)
  console.log('Kitap bilgileri yüklenemedi.');
}
});


    
  }
  // Yorum yapma
  onCreate(entity: CommentRequest) {
    this.createEntity<CommentRequest>(entity, 'Comment')
      .then((response) => {
        if (response?.status == ResponseStatus.Ok) {
          this.messageService.add({ severity: 'success', summary: 'Başarılı', detail: 'Yorum ekleme başarılı', life: 3000 });
        } else {
          this.messageService.add({ severity: 'error', summary: 'Hata', detail: 'Yorum eklenirken bir hata oluştu', life: 3000 });
        }
      })
      .catch((error) => {
        console.error('Hata:', error); // Hata konsola yazdırılır
        this.messageService.add({ severity: 'error', summary: 'Hata', detail: 'Yorum eklenirken bir hata oluştu', life: 3000 });
      });
  }

  createEntity<TEntity>(entity: TEntity, entityType: string) {
    return this.apiService.createEntity<TEntity>(entity, entityType);
  }
}
