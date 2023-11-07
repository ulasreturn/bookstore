import { Injectable } from '@angular/core';
import { Configuration, OpenAIApi } from 'openai';
@Injectable({
  providedIn: 'root'
})
export class OpenaiService {
  private openai: OpenAIApi;
  configuration = new Configuration({
    apiKey: "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", //generate key https://platform.openai.com/
  });
  constructor() {
    this.openai = new OpenAIApi(this.configuration);
  }
  generateText(prompt: string):Promise<string | undefined>{
   return this.openai.createCompletion({
        model: "text-davinci-003",
        prompt: prompt,
        max_tokens: 256
      }).then(response => {
        return response.data.choices[0].text;
      }).catch(error=>{
        return '';
      });
  }
}