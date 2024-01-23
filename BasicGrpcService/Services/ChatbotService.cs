using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System.Text;

namespace BasicGrpcService.Services;

public class ChatbotService : Chatbot.ChatbotBase
{
    private readonly ILogger<ChatbotService> _logger;
    private readonly IChatHistoryStore _historyStore;
    public ChatbotService(ILogger<ChatbotService> logger, IChatHistoryStore historyStore)
    {
        _logger = logger;
        _historyStore = historyStore;
    }

    public override Task<ChatReply> SendMessage(ChatRequest request, ServerCallContext context)
    {
        _logger.LogDebug("Message received from the client {Peer}.", context.Peer);

        var reply = new ChatReply();

        if (request.Message.ToLower().Contains("hello"))
        {
            reply.Message = $"Hello {request.Name}!";
            reply.AnswerFound = true;

            // commented for demonstrating well-known-types
            //reply.AnswerType = AnswerType.Greeting;

            // commented for demonstrating oneof
            //reply.ResponseType = ChatHistoryEntry.Types.ResponseType.Greeting;

        }
        else if (request.Message.ToLower().Contains("help"))
        {
            reply.Message = "What can I help you with today?";
            reply.AnswerFound = true;
            // commented for demonstrating oneof
            //reply.AnswerType = AnswerType.Help;

            // commented for demonstrating well-known-types
            //reply.ResponseType = ChatHistoryEntry.Types.ResponseType.Assistance;
        }
        else
        {
            reply.Message = "I'm sorry, but I am unable to resolve your query.";
            // commented for demonstrating well-known-types
            //reply.UnknownRequest = true;
        }

        reply.ReplyInBytes =
            ByteString.CopyFrom(
                Encoding.ASCII.GetBytes(reply.Message));

        reply.MessageSizeInBytes = reply.ReplyInBytes.Length;
        reply.MessageSizeInMegabytes = (double)reply.MessageSizeInBytes / (1024 * 1024);
        reply.RequestReceivedTime = Timestamp.FromDateTime(DateTime.UtcNow);
        reply.RequestProcessedDuration = reply.RequestReceivedTime - request.RequestStartTime;


        //foreach (var entry in _historyStore.GetHistory())
        //{
        //    reply.MessageHistory[entry.Key] = new ChatHistoryEntry
        //    {
        //        RequestMessage = entry.Value.Item1,
        //        ResponseMessage = entry.Value.Item2,
        //    };
        //}

        _historyStore.AddEntry(request.Message, reply.Message);

        // for (int i = 0; i < 5; i++)
        // {
        //     reply.Payload.Add(GetPayload());
        // }

        return Task.FromResult(reply);
    }

    //private NumericPayload GetPayload()
    //{
    //    return new NumericPayload
    //    {
    //        FloatDemo = 1.1F,
    //        DoubleDemo = 1.2,
    //        Int32Demo = int.MinValue,
    //        Int64Demo = long.MinValue,
    //        Uint32Demo = uint.MaxValue,
    //        Uint64Demo = ulong.MaxValue,
    //        Sint32Demo = int.MinValue,
    //        Sint64Demo = long.MinValue,
    //        Fixed32Demo = uint.MaxValue,
    //        Fixed64Demo = ulong.MaxValue,
    //        Sfixed32Demo = int.MaxValue,
    //        Sfixed64Demo = long.MaxValue,
    //    };
    //}
}