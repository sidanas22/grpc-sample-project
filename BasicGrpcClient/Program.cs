using BasicGrpcService;
using Grpc.Net.Client;
using System.Text;
using System.Text.Json;

Console.WriteLine("What is your name?");
var name = Console.ReadLine();

Console.WriteLine($"Hello {name}. You can start chatting now.");
Console.WriteLine("Type 'exit' to stop at any time.");

using var channel = GrpcChannel.ForAddress("http://127.0.0.1:5100");
var client = new Chatbot.ChatbotClient(channel);

while (true)
{
    var message = Console.ReadLine();

    if (message == "exit")
        break;

    Console.WriteLine($"Message: {message}");

    var reply = await client.SendMessageAsync(
                  new ChatRequest
                  {
                      Name = name,
                      Message = message
                  });
    Console.WriteLine($"Reply: {reply.Message}");
    Console.WriteLine($"Answer found: {reply.AnswerFound}");

    var messageBytes = Encoding
        .UTF8
        .GetString(reply.ReplyInBytes.ToByteArray());

    Console.WriteLine($"Reply from bytes: {messageBytes}");
    Console.WriteLine($"Message size in bytes: {reply.MessageSizeInBytes}");
    Console.WriteLine($"Message size in megabytes: {reply.MessageSizeInMegabytes}");

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