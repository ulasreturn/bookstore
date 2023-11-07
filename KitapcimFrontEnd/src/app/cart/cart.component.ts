import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Books } from 'src/core/models/books.model';
import { ApiService } from 'src/core/services/api/api.service';
import { AuthService } from 'src/core/services/auth/auth.service';
@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
})
export class CartComponent {
  books: any;
  constructor(private readonly authService: AuthService,private readonly apiservice: ApiService,private readonly httpClient: HttpClient,private router: Router ){}

  getBooks() {
    this.apiservice.getAllEntities(Books).subscribe((response) => {
      this.books = response.data;
      console.log(this.books);
    });
  }
  ngOnInit() {
    this.getBooks();
  }
}