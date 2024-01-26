// package: basic_grpc_service
// file: grpc-models/chatbot.proto

import * as jspb from "google-protobuf";
import * as google_protobuf_wrappers_pb from "google-protobuf/google/protobuf/wrappers_pb";
import * as google_protobuf_duration_pb from "google-protobuf/google/protobuf/duration_pb";
import * as google_protobuf_timestamp_pb from "google-protobuf/google/protobuf/timestamp_pb";
import * as google_protobuf_any_pb from "google-protobuf/google/protobuf/any_pb";

export class ChatRequest extends jspb.Message {
  hasName(): boolean;
  clearName(): void;
  getName(): google_protobuf_wrappers_pb.StringValue | undefined;
  setName(value?: google_protobuf_wrappers_pb.StringValue): void;

  hasMessage(): boolean;
  clearMessage(): void;
  getMessage(): google_protobuf_wrappers_pb.StringValue | undefined;
  setMessage(value?: google_protobuf_wrappers_pb.StringValue): void;

  hasRequestStartTime(): boolean;
  clearRequestStartTime(): void;
  getRequestStartTime(): google_protobuf_timestamp_pb.Timestamp | undefined;
  setRequestStartTime(value?: google_protobuf_timestamp_pb.Timestamp): void;

  serializeBinary(): Uint8Array;
  toObject(includeInstance?: boolean): ChatRequest.AsObject;
  static toObject(includeInstance: boolean, msg: ChatRequest): ChatRequest.AsObject;
  static extensions: {[key: number]: jspb.ExtensionFieldInfo<jspb.Message>};
  static extensionsBinary: {[key: number]: jspb.ExtensionFieldBinaryInfo<jspb.Message>};
  static serializeBinaryToWriter(message: ChatRequest, writer: jspb.BinaryWriter): void;
  static deserializeBinary(bytes: Uint8Array): ChatRequest;
  static deserializeBinaryFromReader(message: ChatRequest, reader: jspb.BinaryReader): ChatRequest;
}

export namespace ChatRequest {
  export type AsObject = {
    name?: google_protobuf_wrappers_pb.StringValue.AsObject,
    message?: google_protobuf_wrappers_pb.StringValue.AsObject,
    requestStartTime?: google_protobuf_timestamp_pb.Timestamp.AsObject,
  }
}

export class ChatReply extends jspb.Message {
  hasMessage(): boolean;
  clearMessage(): void;
  getMessage(): google_protobuf_wrappers_pb.StringValue | undefined;
  setMessage(value?: google_protobuf_wrappers_pb.StringValue): void;

  hasAnswerFound(): boolean;
  clearAnswerFound(): void;
  getAnswerFound(): google_protobuf_wrappers_pb.BoolValue | undefined;
  setAnswerFound(value?: google_protobuf_wrappers_pb.BoolValue): void;

  hasReplyInBytes(): boolean;
  clearReplyInBytes(): void;
  getReplyInBytes(): google_protobuf_wrappers_pb.BytesValue | undefined;
  setReplyInBytes(value?: google_protobuf_wrappers_pb.BytesValue): void;

  hasMessageSizeInBytes(): boolean;
  clearMessageSizeInBytes(): void;
  getMessageSizeInBytes(): google_protobuf_wrappers_pb.Int32Value | undefined;
  setMessageSizeInBytes(value?: google_protobuf_wrappers_pb.Int32Value): void;

  hasMessageSizeInMegabytes(): boolean;
  clearMessageSizeInMegabytes(): void;
  getMessageSizeInMegabytes(): google_protobuf_wrappers_pb.DoubleValue | undefined;
  setMessageSizeInMegabytes(value?: google_protobuf_wrappers_pb.DoubleValue): void;

  hasRequestReceivedTime(): boolean;
  clearRequestReceivedTime(): void;
  getRequestReceivedTime(): google_protobuf_timestamp_pb.Timestamp | undefined;
  setRequestReceivedTime(value?: google_protobuf_timestamp_pb.Timestamp): void;

  hasRequestProcessedDuration(): boolean;
  clearRequestProcessedDuration(): void;
  getRequestProcessedDuration(): google_protobuf_duration_pb.Duration | undefined;
  setRequestProcessedDuration(value?: google_protobuf_duration_pb.Duration): void;

  hasDynamicPayload(): boolean;
  clearDynamicPayload(): void;
  getDynamicPayload(): google_protobuf_any_pb.Any | undefined;
  setDynamicPayload(value?: google_protobuf_any_pb.Any): void;

  clearPackedNumbersList(): void;
  getPackedNumbersList(): Array<number>;
  setPackedNumbersList(value: Array<number>): void;
  addPackedNumbers(value: number, index?: number): number;

  hasOptionalField(): boolean;
  clearOptionalField(): void;
  getOptionalField(): number;
  setOptionalField(value: number): void;

  serializeBinary(): Uint8Array;
  toObject(includeInstance?: boolean): ChatReply.AsObject;
  static toObject(includeInstance: boolean, msg: ChatReply): ChatReply.AsObject;
  static extensions: {[key: number]: jspb.ExtensionFieldInfo<jspb.Message>};
  static extensionsBinary: {[key: number]: jspb.ExtensionFieldBinaryInfo<jspb.Message>};
  static serializeBinaryToWriter(message: ChatReply, writer: jspb.BinaryWriter): void;
  static deserializeBinary(bytes: Uint8Array): ChatReply;
  static deserializeBinaryFromReader(message: ChatReply, reader: jspb.BinaryReader): ChatReply;
}

export namespace ChatReply {
  export type AsObject = {
    message?: google_protobuf_wrappers_pb.StringValue.AsObject,
    answerFound?: google_protobuf_wrappers_pb.BoolValue.AsObject,
    replyInBytes?: google_protobuf_wrappers_pb.BytesValue.AsObject,
    messageSizeInBytes?: google_protobuf_wrappers_pb.Int32Value.AsObject,
    messageSizeInMegabytes?: google_protobuf_wrappers_pb.DoubleValue.AsObject,
    requestReceivedTime?: google_protobuf_timestamp_pb.Timestamp.AsObject,
    requestProcessedDuration?: google_protobuf_duration_pb.Duration.AsObject,
    dynamicPayload?: google_protobuf_any_pb.Any.AsObject,
    packedNumbersList: Array<number>,
    optionalField: number,
  }
}

export class ChatHistoryEntry extends jspb.Message {
  getRequestMessage(): string;
  setRequestMessage(value: string): void;

  getResponseMessage(): string;
  setResponseMessage(value: string): void;

  serializeBinary(): Uint8Array;
  toObject(includeInstance?: boolean): ChatHistoryEntry.AsObject;
  static toObject(includeInstance: boolean, msg: ChatHistoryEntry): ChatHistoryEntry.AsObject;
  static extensions: {[key: number]: jspb.ExtensionFieldInfo<jspb.Message>};
  static extensionsBinary: {[key: number]: jspb.ExtensionFieldBinaryInfo<jspb.Message>};
  static serializeBinaryToWriter(message: ChatHistoryEntry, writer: jspb.BinaryWriter): void;
  static deserializeBinary(bytes: Uint8Array): ChatHistoryEntry;
  static deserializeBinaryFromReader(message: ChatHistoryEntry, reader: jspb.BinaryReader): ChatHistoryEntry;
}

export namespace ChatHistoryEntry {
  export type AsObject = {
    requestMessage: string,
    responseMessage: string,
  }

  export interface ResponseTypeMap {
    UNKNOWN: 0;
    HELP: 1;
    GREETING: 2;
  }

  export const ResponseType: ResponseTypeMap;
}

export interface AnswerTypeMap {
  UNKNOWN: 0;
  HELP: 1;
  GREETING: 2;
}

export const AnswerType: AnswerTypeMap;

