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

    /// <summary>Client for Winter</summary>
    public partial class WinterClient : grpc::ClientBase<WinterClient>
    {
      /// <summary>Creates a new client for Winter</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public WinterClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Winter that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public WinterClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected WinterClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected WinterClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Tema2CNA.Protos.WinterResponse GetWinterSign(global::Tema2CNA.Protos.WinterRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetWinterSign(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Tema2CNA.Protos.WinterResponse GetWinterSign(global::Tema2CNA.Protos.WinterRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetWinterSign, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Tema2CNA.Protos.WinterResponse> GetWinterSignAsync(global::Tema2CNA.Protos.WinterRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetWinterSignAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Tema2CNA.Protos.WinterResponse> GetWinterSignAsync(global::Tema2CNA.Protos.WinterRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetWinterSign, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override WinterClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new WinterClient(configuration);
      }
    }

  }
}
#endregion
