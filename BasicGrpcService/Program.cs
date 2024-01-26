using BasicGrpcService;
using BasicGrpcService.Services;
using Microsoft.AspNetCore.Server.Kestrel.Core;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGrpc(options =>
{
    options.EnableDetailedErrors = true;
    options.MaxReceiveMessageSize = 2 * 1024 * 1024;
    options.MaxSendMessageSize = 5 * 1024 * 1024;
    options.ResponseCompressionLevel = null;
    options.IgnoreUnknownServices = true;
    options.Interceptors.Add<TraceInterceptor>();
    options.Interceptors.Add<LoggingInterceptor>();

    Console.WriteLine(options.CompressionProviders.Count);
});

builder.Services.AddSingleton<TraceInterceptor>();
builder.Services.AddSingleton<LoggingInterceptor>();
builder.Services.AddSingleton<IChatHistoryStore, ChatHistoryStore>();

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(5000, o => o.Protocols =
        HttpProtocols.Http1);

    options.ListenAnyIP(5100, o => o.Protocols =
        HttpProtocols.Http2);

    options.ListenAnyIP(7100, listenOptions =>
    {
        listenOptions.Protocols = HttpProtocols.Http2;
        listenOptions.UseHttps();
    });
});

var app = builder.Build();

app.UseGrpcWeb();

app.MapGrpcService<ChatbotService>().EnableGrpcWeb();

app.MapGet("/", () => "gRPC service is running.");

app.Run();
