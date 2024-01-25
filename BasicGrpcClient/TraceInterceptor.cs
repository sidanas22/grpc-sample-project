using Grpc.Core;
using Grpc.Core.Interceptors;

namespace BasicGrpcClient;

internal class TraceInterceptor : Interceptor
{
    public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(
        TRequest request,
        ClientInterceptorContext<TRequest, TResponse> context,
        AsyncUnaryCallContinuation<TRequest, TResponse> continuation)
    {
        Console.WriteLine(
            $"Starting a {context.Method.Type} call on {context.Method.Name} method.");
        return continuation(request, context);
    }

    public override AsyncDuplexStreamingCall<TRequest, TResponse> AsyncDuplexStreamingCall<TRequest, TResponse>(
        ClientInterceptorContext<TRequest, TResponse> context,
        AsyncDuplexStreamingCallContinuation<TRequest, TResponse> continuation
        )
    {
        Console.WriteLine(
            $"Starting a {context.Method.Type} call on {context.Method.Name} method.");
        return base.AsyncDuplexStreamingCall(context, continuation);
    }

}