import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

import { grpc } from "@improbable-eng/grpc-web";
import { ChatRequest } from './core/grpc-models/chatbot_pb';
import { StringValue } from 'google-protobuf/google/protobuf/wrappers_pb';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  messages: { direction: string, name: string, message: string, timeSent: string }[] = [];
  userInput: string = '';
  checkoutForm: FormGroup = this.formBuilder.group({
    message: ''
  });

  constructor(private http: HttpClient,  private formBuilder: FormBuilder) { }

  ngOnInit() {
    // this.getForecasts();

    this.messages.push(
      {
        direction: "left",
        name: "BOT",
        message: "Hello, welcome to GRPC Chat! What is your name? 😄",
        timeSent: (new Date()).toTimeString()
      }
    )

    // let chatRequest: ChatRequest = new ChatRequest();
    // let name: StringValue = new StringValue();
    // name.setValue("Anas")
    // chatRequest.setName(name);

  }

  // getForecasts() {
  //   this.http.get<WeatherForecast[]>('/weatherforecast').subscribe(
  //     (result) => {
  //       this.forecasts = result;
  //     },
  //     (error) => {
  //       console.error(error);
  //     }
  //   );
  // }


  // const msgerForm = get(".msger-inputarea");
  // const msgerInput = get(".msger-input");
  // const msgerChat = get(".msger-chat");

  // const BOT_MSGS = [
  //   "Hi, how are you?",
  //   "Ohh... I can't understand what you trying to say. Sorry!",
  //   "I like to play games... But I don't know how to play!",
  //   "Sorry if my answers are not relevant. :))",
  //   "I feel sleepy! :("
  // ];

  // Icons made by Freepik from www.flaticon.com
  // const BOT_IMG = "https://image.flaticon.com/icons/svg/327/327779.svg";
  // const PERSON_IMG = "https://image.flaticon.com/icons/svg/145/145867.svg";
  // const BOT_NAME = "CHATBOT";
  // const PERSON_NAME = "User";

  // msgerForm.addEventListener("submit", event => {
  //     event.preventDefault();

  // const msgText = msgerInput.value;
  // if (!msgText) return;

  // appendMessage(PERSON_NAME, PERSON_IMG, "right", msgText);
  // msgerInput.value = "";

  // botResponse();
  // });

  // function appendMessage(name, img, side, text) {
  //   //   Simple solution for small apps
  //   const msgHTML = `
  //     <div class="msg ${side}-msg">
  //       <div class="msg-img" style="background-image: url(${img})"></div>

  //       <div class="msg-bubble">
  //         <div class="msg-info">
  //           <div class="msg-info-name">${name}</div>
  //           <div class="msg-info-time">${formatDate(new Date())}</div>
  //         </div>

  //         <div class="msg-text">${text}</div>
  //       </div>
  //     </div>
  //   `;

  //   msgerChat.insertAdjacentHTML("beforeend", msgHTML);
  //   msgerChat.scrollTop += 500;
  // }

  // function botResponse() {
  //   const r = random(0, BOT_MSGS.length - 1);
  //   const msgText = BOT_MSGS[r];
  //   const delay = msgText.split(" ").length * 100;

  //   setTimeout(() => {
  //     appendMessage(BOT_NAME, BOT_IMG, "left", msgText);
  //   }, delay);
  // }

  // // Utils
  // function get(selector, root = document) {
  //   return root.querySelector(selector);
  // }

  // function formatDate(date) {
  //   const h = "0" + date.getHours();
  //   const m = "0" + date.getMinutes();

  //   return `${h.slice(-2)}:${m.slice(-2)}`;
  // }

  // function random(min, max) {
  //   return Math.floor(Math.random() * (max - min) + min);
  // }

  sendMessage() {
    // if (this.userInput.trim() !== '') {
    //   this.messages.push({ text: this.userInput, sender: "user" });
    //   this.userInput = '';
    //   this.receiveBotMessage();
    // }

    if (this.messages.length === 1) {
      this.messages.push(
        {
          direction: "right",
          name: this.userInput,
          message: this.userInput,
          timeSent: (new Date()).toTimeString()
        }
      )
    }

  }


  title = 'AngularClient';
}
