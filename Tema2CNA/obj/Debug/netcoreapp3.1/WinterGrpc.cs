// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/winter.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Tema2CNA.Protos {
  public static partial class Winter
  {
    static readonly string __ServiceName = "Winter";

    static readonly grpc::Marshaller<global::Tema2CNA.Protos.WinterRequest> __Marshaller_WinterRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Tema2CNA.Protos.WinterRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Tema2CNA.Protos.WinterResponse> __Marshaller_WinterResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Tema2CNA.Protos.WinterResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Tema2CNA.Protos.WinterRequest, global::Tema2CNA.Protos.WinterResponse> __Method_GetWinterSign = new grpc::Method<global::Tema2CNA.Protos.WinterRequest, global::Tema2CNA.Protos.WinterResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetWinterSign",
        __Marshaller_WinterRequest,
        __Marshaller_WinterResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Tema2CNA.Protos.WinterReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Winter</summary>
    [grpc::BindServiceMethod(typeof(Winter), "BindService")]
    public abstract partial class WinterBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Tema2CNA.Protos.WinterResponse> GetWinterSign(global::Tema2CNA.Protos.WinterRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(WinterBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetWinterSign, serviceImpl.GetWinterSign).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, WinterBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetWinterSign, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Tema2CNA.Protos.WinterRequest, global::Tema2CNA.Protos.WinterResponse>(serviceImpl.GetWinterSign));
    }

  }
}
#endregion
