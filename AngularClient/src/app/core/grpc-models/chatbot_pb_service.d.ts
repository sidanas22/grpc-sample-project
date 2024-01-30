// package: basic_grpc_service
// file: grpc-models/chatbot.proto

import * as grpc_models_chatbot_pb from "../grpc-models/chatbot_pb";
import {grpc} from "@improbable-eng/grpc-web";

type ChatbotSendMessage = {
  readonly methodName: string;
  readonly service: typeof Chatbot;
  readonly requestStream: false;
  readonly responseStream: true;
  readonly requestType: typeof grpc_models_chatbot_pb.ChatRequest;
  readonly responseType: typeof grpc_models_chatbot_pb.ChatReply;
};

export class Chatbot {
  static readonly serviceName: string;
  static readonly SendMessage: ChatbotSendMessage;
}

export type ServiceError = { message: string, code: number; metadata: grpc.Metadata }
export type Status = { details: string, code: number; metadata: grpc.Metadata }

interface UnaryResponse {
  cancel(): void;
}
interface ResponseStream<T> {
  cancel(): void;
  on(type: 'data', handler: (message: T) => void): ResponseStream<T>;
  on(type: 'end', handler: (status?: Status) => void): ResponseStream<T>;
  on(type: 'status', handler: (status: Status) => void): ResponseStream<T>;
}
interface RequestStream<T> {
  write(message: T): RequestStream<T>;
  end(): void;
  cancel(): void;
  on(type: 'end', handler: (status?: Status) => void): RequestStream<T>;
  on(type: 'status', handler: (status: Status) => void): RequestStream<T>;
}
interface BidirectionalStream<ReqT, ResT> {
  write(message: ReqT): BidirectionalStream<ReqT, ResT>;
  end(): void;
  cancel(): void;
  on(type: 'data', handler: (message: ResT) => void): BidirectionalStream<ReqT, ResT>;
  on(type: 'end', handler: (status?: Status) => void): BidirectionalStream<ReqT, ResT>;
  on(type: 'status', handler: (status: Status) => void): BidirectionalStream<ReqT, ResT>;
}

export class ChatbotClient {
  readonly serviceHost: string;

  constructor(serviceHost: string, options?: grpc.RpcOptions);
  sendMessage(requestMessage: grpc_models_chatbot_pb.ChatRequest, metadata?: grpc.Metadata): ResponseStream<grpc_models_chatbot_pb.ChatReply>;
}

