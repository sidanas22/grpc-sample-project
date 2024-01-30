// package: basic_grpc_service
// file: grpc-models/chatbot.proto

var grpc_models_chatbot_pb = require("../grpc-models/chatbot_pb");
var grpc = require("@improbable-eng/grpc-web").grpc;

var Chatbot = (function () {
  function Chatbot() {}
  Chatbot.serviceName = "basic_grpc_service.Chatbot";
  return Chatbot;
}());

Chatbot.SendMessage = {
  methodName: "SendMessage",
  service: Chatbot,
  requestStream: false,
  responseStream: true,
  requestType: grpc_models_chatbot_pb.ChatRequest,
  responseType: grpc_models_chatbot_pb.ChatReply
};

exports.Chatbot = Chatbot;

function ChatbotClient(serviceHost, options) {
  this.serviceHost = serviceHost;
  this.options = options || {};
}

ChatbotClient.prototype.sendMessage = function sendMessage(requestMessage, metadata) {
  var listeners = {
    data: [],
    end: [],
    status: []
  };
  var client = grpc.invoke(Chatbot.SendMessage, {
    request: requestMessage,
    host: this.serviceHost,
    metadata: metadata,
    transport: this.options.transport,
    debug: this.options.debug,
    onMessage: function (responseMessage) {
      listeners.data.forEach(function (handler) {
        handler(responseMessage);
      });
    },
    onEnd: function (status, statusMessage, trailers) {
      listeners.status.forEach(function (handler) {
        handler({ code: status, details: statusMessage, metadata: trailers });
      });
      listeners.end.forEach(function (handler) {
        handler({ code: status, details: statusMessage, metadata: trailers });
      });
      listeners = null;
    }
  });
  return {
    on: function (type, handler) {
      listeners[type].push(handler);
      return this;
    },
    cancel: function () {
      listeners = null;
      client.close();
    }
  };
};

exports.ChatbotClient = ChatbotClient;

