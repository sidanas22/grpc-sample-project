using BasicGrpcClient;
using BasicGrpcService;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Grpc.Core.Interceptors;
using Grpc.Net.Client;
using Microsoft.Extensions.Logging;
using System.Text;
using System.Text.Json;

Console.WriteLine("What is your name?");
var name = Console.ReadLine();

Console.WriteLine($"Hello {name}. You can start chatting now.");
Console.WriteLine("Type 'exit' to stop at any time.");


var options = new GrpcChannelOptions
{
    HttpHandler = null,
    HttpClient = null,
    DisposeHttpClient = false,
    MaxSendMessageSize = null,
    MaxReceiveMessageSize = null,
    Credentials = null,
    CompressionProviders = null,
    ThrowOperationCanceledOnCancellation = false,
    UnsafeUseInsecureChannelCallCredentials = false,
    MaxRetryAttempts = 5,
    MaxRetryBufferSize = null,
    MaxRetryBufferPerCallSize = null,
    ServiceConfig = null,
    // Logger Factory
    LoggerFactory = LoggerFactory.Create(logging =>
    {
        logging.SetMinimumLevel(LogLevel.Debug);
    })
};

using var channel = GrpcChannel.ForAddress("http://127.0.0.1:5100", options);
var callInvoker = channel.Intercept(new TraceInterceptor());

//var client = new Chatbot.ChatbotClient(channel);
var client = new Chatbot.ChatbotClient(callInvoker);

while (true)
{
    var message = Console.ReadLine();

    if (message == "exit")
        break;

    Console.WriteLine($"Message: {message}");

    //var reply = await client.SendMessageAsync(
    //              new ChatRequest
    //              {
    //                  Name = name,
    //                  Message = message,
    //                  RequestStartTime = Timestamp.FromDateTime(DateTime.UtcNow)
    //              });

    /*
    using var call = client.SendMessage(
        new ChatRequest
        {
            Name = name,
            Message = message,
            RequestStartTime = Timestamp.FromDateTime(DateTime.UtcNow)

        });

    while (await call.ResponseStream.MoveNext(CancellationToken.None))
    {
        Console.WriteLine($"Reply: {call.ResponseStream.Current.Message}");
    }
    */

    using var call = client.SendMessages();

    var readTask = Task.Run(async () =>
    {
        await foreach (var response in call.ResponseStream.ReadAllAsync())
        {
            Console.WriteLine($"Reply: {response.Message}");
        }
    });

    await call.RequestStream.WriteAsync(new ChatRequest
    {
        Name = name,
        Message = message,
        RequestStartTime = Timestamp.FromDateTime(DateTime.UtcNow)
    });

    await call.RequestStream.WriteAsync(new ChatRequest
    {
        Name = name,
        Message = $"This message came from {name}.",
        RequestStartTime = Timestamp.FromDateTime(DateTime.UtcNow)
    });

    await call.RequestStream.CompleteAsync();
    // No longer need to await call object since this is a bidirectional grpc call
    //var response = await call;
    //We do need to await readTask now
    await readTask;

    //Console.WriteLine($"Reply: {response.Message}");


    /*
    Console.WriteLine($"Reply: {reply.Message}");
    Console.WriteLine($"Answer found: {reply.AnswerFound}");

    var messageBytes = Encoding
        .UTF8
        .GetString(reply.ReplyInBytes.ToByteArray());

    Console.WriteLine($"Reply from bytes: {messageBytes}");
    Console.WriteLine($"Message size in bytes: {reply.MessageSizeInBytes}");
    Console.WriteLine($"Message size in megabytes: {reply.MessageSizeInMegabytes}");
    Console.WriteLine($"Request received time: {reply.RequestReceivedTime}");
    Console.WriteLine($"Request processed duration: {reply.RequestProcessedDuration}");
    Console.WriteLine($"Complete Reply Object: {JsonSerializer.Serialize(reply, new JsonSerializerOptions(){WriteIndented = true})}");
    Console.WriteLine($"Raw dynamic payload: {JsonSerializer.Serialize(reply.DynamicPayload)}");
    Console.WriteLine($"Unpacked dynamic payload: {JsonSerializer.Serialize(reply.DynamicPayload.Unpack<ChatRequest>())}");
    */



    /*
     // Commented for demonstrating well-known types
    
    Console.WriteLine($"Answer Type: {reply.AnswerType}");
    Console.WriteLine($"Response type: {reply.ResponseType}");
    Console.WriteLine($"Unknown request: {reply.UnknownRequest}");
    
    Console.WriteLine("Older Message:");
    foreach(var entry in reply.MessageHistory)
    {
        Console.WriteLine($"Key: {entry.Key}, {entry.Value.RequestMessage}, {entry.Value.ResponseMessage}");
    }

    */

    //var payloadString = JsonSerializer.Serialize(reply.Payload);

    //Console.WriteLine($"Payload: {payloadString}");
}

Console.ReadKey();