// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: proto/weather.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace WeatherNamespace {
  public static partial class WeatherService
  {
    static readonly string __ServiceName = "weather.WeatherService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::WeatherNamespace.WeatherRequest> __Marshaller_weather_WeatherRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::WeatherNamespace.WeatherRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::WeatherNamespace.WeatherForecastResponse> __Marshaller_weather_WeatherForecastResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::WeatherNamespace.WeatherForecastResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::WeatherNamespace.DataRequest> __Marshaller_weather_DataRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::WeatherNamespace.DataRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::WeatherNamespace.DataResponse> __Marshaller_weather_DataResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::WeatherNamespace.DataResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::WeatherNamespace.WeatherRequest, global::WeatherNamespace.WeatherForecastResponse> __Method_GetWeatherForecast = new grpc::Method<global::WeatherNamespace.WeatherRequest, global::WeatherNamespace.WeatherForecastResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetWeatherForecast",
        __Marshaller_weather_WeatherRequest,
        __Marshaller_weather_WeatherForecastResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::WeatherNamespace.DataRequest, global::WeatherNamespace.DataResponse> __Method_SendToB = new grpc::Method<global::WeatherNamespace.DataRequest, global::WeatherNamespace.DataResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SendToB",
        __Marshaller_weather_DataRequest,
        __Marshaller_weather_DataResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::WeatherNamespace.WeatherReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of WeatherService</summary>
    [grpc::BindServiceMethod(typeof(WeatherService), "BindService")]
    public abstract partial class WeatherServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::WeatherNamespace.WeatherForecastResponse> GetWeatherForecast(global::WeatherNamespace.WeatherRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::WeatherNamespace.DataResponse> SendToB(global::WeatherNamespace.DataRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(WeatherServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetWeatherForecast, serviceImpl.GetWeatherForecast)
          .AddMethod(__Method_SendToB, serviceImpl.SendToB).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, WeatherServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetWeatherForecast, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::WeatherNamespace.WeatherRequest, global::WeatherNamespace.WeatherForecastResponse>(serviceImpl.GetWeatherForecast));
      serviceBinder.AddMethod(__Method_SendToB, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::WeatherNamespace.DataRequest, global::WeatherNamespace.DataResponse>(serviceImpl.SendToB));
    }

  }
}
#endregion
