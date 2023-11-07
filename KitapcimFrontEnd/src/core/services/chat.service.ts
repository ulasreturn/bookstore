import { Injectable } from "@angular/core";
import { Observable, Subject } from "rxjs";

export class Message {
  constructor(public author: string, public content: string) {}
}

@Injectable()
export class ChatService {
  private audioFile: HTMLAudioElement;

  constructor() {
    this.audioFile = new Audio("https://s3-us-west-2.amazonaws.com/s.cdpn.io/3/success.mp3");
  }

  conversation = new Subject<Message[]>();

  messageMap: { [key: string]: string } = {
    Merhaba:"Merhaba, KITAPCIM'a hoşgeldiniz. Nasıl yardımcı olabilirim? ( Proje ekibi, Kitapcım nedir,Ekip Lideri,İş Analisti..)",
    Hello: "Hello",
    Hi: "Hello",
    Nasılsın: "İyiyim, ya sen?",
    İyiyim:"Ne güzel! Bana ne sormak istersin?",
    "Who are you": "My name is Kitapcım Bot",
    "Kitapcım": "Kitapcım, okurseverlere ikinci el kitap satın almayı ve satmayı kolaylaştıran bir e-ticaret platformudur.Ayrıca, KITAPCIM kitapların raflarda tozlanmamasını sağlamak ve uygun fiyatlarla paylaşıma açık olmasını teşvik etmek amacıyla okursevenlere kolaylık sunar.",
    "Kitapcım nedir": "Kitapcım, okurseverlere ikinci el kitap satın almayı ve satmayı kolaylaştıran bir e-ticaret platformudur.Ayrıca, KITAPCIM kitapların raflarda tozlanmamasını sağlamak ve uygun fiyatlarla paylaşıma açık olmasını teşvik etmek amacıyla okursevenlere kolaylık sunar.",
    "Kitapcım nedir?": "Kitapcım, okurseverlere ikinci el kitap satın almayı ve satmayı kolaylaştıran bir e-ticaret platformudur.Ayrıca, KITAPCIM kitapların raflarda tozlanmamasını sağlamak ve uygun fiyatlarla paylaşıma açık olmasını teşvik etmek amacıyla okursevenlere kolaylık sunar.",
    "Ekip": "Ekibimiz: Ulaş Ergin, Mustafa Onur Durgun, Pelda Petekkaya.",
    "Proje ekibi kimler?": "Ekibimiz: Ulaş Ergin, Mustafa Onur Durgun, Pelda Petekkaya.",
    "Proje ekibi": "Ekibimiz: Ulaş Ergin, Mustafa Onur Durgun, Pelda Petekkaya.",
    "Ekip Lideri": "Ekip liderimiz: Mustafa Onur Durgun",
    "İş Analisti": "İş Analisti: Ulaş Ergin",
    default: "Anlamadım. Tekrar eder misin?"
  };

  getBotAnswer(msg: string) {
    const userMessage = new Message("user", msg);
    this.conversation.next([userMessage]);
    const botMessage = new Message("bot", this.getBotMessage(msg));

    setTimeout(() => {
      this.playFile();
      this.conversation.next([botMessage]);
    }, 1500);
  }

  playFile() {
    this.audioFile.play();
  }

  getBotMessage(question: string) {
    let answer = this.messageMap[question];
    return answer || this.messageMap["default"];
  }
}
