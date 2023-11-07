import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './homepage/home.component';
import { ChatbotComponent } from './chatbot/chatbot.component';
import { ChatService } from 'src/core/services/chat.service';

@NgModule({
  imports: [
    CommonModule,
    FormsModule
  ],
  declarations: [],
  providers: [ChatService]
})
export class AngularBotModule { }