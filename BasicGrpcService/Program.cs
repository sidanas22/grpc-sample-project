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

//builder.Services.AddCors(options =>
//{
//    options.AddPolicy(
//        name: "AllowOrigin",
//        builder =>
//        {
//            builder.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod();
//        }
//        );
//});

builder.Services.AddCors(o => o.AddPolicy("AllowAll", builder =>
{
    builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader()
            .WithExposedHeaders("Grpc-Status", "Grpc-Message", "Grpc-Encoding", "Grpc-Accept-Encoding");
}));


builder.Services.AddSingleton<TraceInterceptor>();
builder.Services.AddSingleton<LoggingInterceptor>();
builder.Services.AddSingleton<IChatHistoryStore, ChatHistoryStore>();

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

//builder.WebHost.ConfigureKestrel(options =>
//{
//    options.ListenAnyIP(5000, o => o.Protocols =
//        HttpProtocols.Http1);

//    options.ListenAnyIP(5100, o => o.Protocols =
//        HttpProtocols.Http2);

//    options.ListenAnyIP(7100, listenOptions =>
//    {
//        listenOptions.Protocols = HttpProtocols.Http2;
//        listenOptions.UseHttps();
//    });
//});

var app = builder.Build();
app.UseGrpcWeb();
app.UseCors("AllowOrigin");

app.MapGrpcService<ChatbotService>().EnableGrpcWeb().RequireCors("AllowAll");

app.MapGet("/", () => "gRPC service is running.");

app.Run();
