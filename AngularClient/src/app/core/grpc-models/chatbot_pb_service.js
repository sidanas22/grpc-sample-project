// package: basic_grpc_service
// file: grpc-models/chatbot.proto

var grpc_models_chatbot_pb = require("../grpc-models/chatbot_pb");
var grpc = require("@improbable-eng/grpc-web").grpc;

var Chatbot = (function () {
  function Chatbot() {}
  Chatbot.serviceName = "basic_grpc_service.Chatbot";
  return Chatbot;
}());

Chatbot.SendMessages = {
  methodName: "SendMessages",
  service: Chatbot,
  requestStream: true,
  responseStream: true,
  requestType: grpc_models_chatbot_pb.ChatRequest,
  responseType: grpc_models_chatbot_pb.ChatReply
};

exports.Chatbot = Chatbot;

function ChatbotClient(serviceHost, options) {
  this.serviceHost = serviceHost;
  this.options = options || {};
}

ChatbotClient.prototype.sendMessages = function sendMessages(metadata) {
  var listeners = {
    data: [],
    end: [],
    status: []
  };
  var client = grpc.client(Chatbot.SendMessages, {
    host: this.serviceHost,
    metadata: metadata,
    transport: this.options.transport
  });
  client.onEnd(function (status, statusMessage, trailers) {
    listeners.status.forEach(function (handler) {
      handler({ code: status, details: statusMessage, metadata: trailers });
    });
    listeners.end.forEach(function (handler) {
      handler({ code: status, details: statusMessage, metadata: trailers });
    });
    listeners = null;
  });
  client.onMessage(function (message) {
    listeners.data.forEach(function (handler) {
      handler(message);
    })
  });
  client.start(metadata);
  return {
    on: function (type, handler) {
      listeners[type].push(handler);
      return this;
    },
    write: function (requestMessage) {
      client.send(requestMessage);
      return this;
    },
    end: function () {
      client.finishSend();
    },
    cancel: function () {
      listeners = null;
      client.close();
    }
  };
};

exports.ChatbotClient = ChatbotClient;

