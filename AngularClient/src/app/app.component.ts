import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

import { grpc } from "@improbable-eng/grpc-web";
import { ChatRequest, ChatReply } from './core/grpc-models/chatbot_pb';
import { StringValue } from 'google-protobuf/google/protobuf/wrappers_pb';
import { Chatbot, ChatbotClient } from './core/grpc-models/chatbot_pb_service';
import { Request } from '@improbable-eng/grpc-web/dist/typings/invoke';
import { Timestamp } from 'google-protobuf/google/protobuf/timestamp_pb';
import { FieldMask } from 'google-protobuf/google/protobuf/field_mask_pb';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  messages: { direction: string, name: string, message: string, timeSent: string }[] = [];
  userName: string = '';

  checkoutForm: FormGroup = this.formBuilder.group({
    message: ''
  });

  grpcClient?: Request;

  constructor(private http: HttpClient, private formBuilder: FormBuilder) { }

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

  // startStream(){
  //   const
  // }

  onSubmit(): void {
    if (this.messages.length === 1) {
      this.messages.push(
        {
          direction: "right",
          name: this.checkoutForm.getRawValue().message,
          message: this.checkoutForm.getRawValue().message,
          timeSent: (new Date()).toTimeString()
        }
      )
      this.userName = this.checkoutForm.getRawValue().message
      this.messages.push(
        {
          direction: "left",
          name: 'BOT',
          message: `Hello ${this.userName}! You can write your query now.`,
          timeSent: (new Date()).toTimeString()
        }
      )


    }
    else {


      this.messages.push(
        {
          direction: "right",
          name: this.userName,
          message: this.checkoutForm.getRawValue().message,
          timeSent: (new Date()).toTimeString()
        }
      )

      let chatRequest: ChatRequest = new ChatRequest();

      let name: StringValue = new StringValue();
      name.setValue(this.userName)
      chatRequest.setName(name);

      let requestMessage: StringValue = new StringValue();
      requestMessage.setValue(this.checkoutForm.getRawValue().message)
      chatRequest.setMessage(requestMessage)

      let requestStartTime = new Timestamp()
      requestStartTime.fromDate(new Date())
      chatRequest.setRequestStartTime(requestStartTime)


      let mask = new FieldMask();
      mask.addPaths("message")
      chatRequest.setSampleMask(mask)

      this.grpcClient = grpc.invoke(Chatbot.SendMessage, {
        request: chatRequest,
        host: `https://127.0.0.1:7100`,
        onMessage: (reply: ChatReply) => {

          console.log(reply.toObject())
          let replyMessage = reply.getMessage();

          this.messages.push({
            direction: 'left',
            name: 'BOT',
            message: replyMessage ? replyMessage.toString() : 'UNDEFINED REPLY FROM BOT SERVER',
            timeSent: (new Date()).toTimeString()
          });
        },
        onEnd: (code: grpc.Code, msg: string | undefined, trailers: grpc.Metadata) => {
          if (code == grpc.Code.OK) {
            console.log('request finished wihtout any error');
          } else {
            console.log('an error occured', code, msg, trailers);
          }
        },
      });

    }

    this.checkoutForm.reset();
  }


  title = 'AngularClient';
}
