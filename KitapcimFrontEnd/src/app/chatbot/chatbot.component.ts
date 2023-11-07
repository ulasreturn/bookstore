import { Component, OnInit } from '@angular/core';
import {Message,ChatService} from 'src/core/services/chat.service';


@Component({
  selector: 'app-chatbot',
  templateUrl: './chatbot.component.html',
  styleUrls: ['./chatbot.component.css'],
})
export class ChatbotComponent implements OnInit {
  chatbotActive: boolean = false;

  toggleChatbot() {
    this.chatbotActive = !this.chatbotActive;
  }

  messages: Message[] = [];
  value!: string;

  constructor(public chatService: ChatService) { }

  ngOnInit() {
      this.chatService.conversation.subscribe((val) => {
      this.messages = this.messages.concat(val);
    });
  }

  sendMessage() {
    this.chatService.getBotAnswer(this.value);
    this.value = '';
  }

  // Chatbot HTML elementlerini seçin
}
