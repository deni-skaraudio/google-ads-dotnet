// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/ads/googleads/v0/services/recommendation_service.proto
// Original file comments:
// Copyright 2018 Google LLC.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
//
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace Google.Ads.GoogleAds.V0.Services {
  /// <summary>
  /// Service to manage recommendations.
  /// </summary>
  public static partial class RecommendationService
  {
    static readonly string __ServiceName = "google.ads.googleads.v0.services.RecommendationService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Services.GetRecommendationRequest> __Marshaller_GetRecommendationRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Services.GetRecommendationRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Resources.Recommendation> __Marshaller_Recommendation = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Resources.Recommendation.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Services.ApplyRecommendationRequest> __Marshaller_ApplyRecommendationRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Services.ApplyRecommendationRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Services.ApplyRecommendationResponse> __Marshaller_ApplyRecommendationResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Services.ApplyRecommendationResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Services.DismissRecommendationRequest> __Marshaller_DismissRecommendationRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Services.DismissRecommendationRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Services.DismissRecommendationResponse> __Marshaller_DismissRecommendationResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Services.DismissRecommendationResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V0.Services.GetRecommendationRequest, global::Google.Ads.GoogleAds.V0.Resources.Recommendation> __Method_GetRecommendation = new grpc::Method<global::Google.Ads.GoogleAds.V0.Services.GetRecommendationRequest, global::Google.Ads.GoogleAds.V0.Resources.Recommendation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetRecommendation",
        __Marshaller_GetRecommendationRequest,
        __Marshaller_Recommendation);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V0.Services.ApplyRecommendationRequest, global::Google.Ads.GoogleAds.V0.Services.ApplyRecommendationResponse> __Method_ApplyRecommendation = new grpc::Method<global::Google.Ads.GoogleAds.V0.Services.ApplyRecommendationRequest, global::Google.Ads.GoogleAds.V0.Services.ApplyRecommendationResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ApplyRecommendation",
        __Marshaller_ApplyRecommendationRequest,
        __Marshaller_ApplyRecommendationResponse);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V0.Services.DismissRecommendationRequest, global::Google.Ads.GoogleAds.V0.Services.DismissRecommendationResponse> __Method_DismissRecommendation = new grpc::Method<global::Google.Ads.GoogleAds.V0.Services.DismissRecommendationRequest, global::Google.Ads.GoogleAds.V0.Services.DismissRecommendationResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DismissRecommendation",
        __Marshaller_DismissRecommendationRequest,
        __Marshaller_DismissRecommendationResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V0.Services.RecommendationServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of RecommendationService</summary>
    public abstract partial class RecommendationServiceBase
    {
      /// <summary>
      /// Returns the requested recommendation in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V0.Resources.Recommendation> GetRecommendation(global::Google.Ads.GoogleAds.V0.Services.GetRecommendationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Applies given recommendations with corresponding apply parameters.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V0.Services.ApplyRecommendationResponse> ApplyRecommendation(global::Google.Ads.GoogleAds.V0.Services.ApplyRecommendationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Dismisses given recommendations.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V0.Services.DismissRecommendationResponse> DismissRecommendation(global::Google.Ads.GoogleAds.V0.Services.DismissRecommendationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for RecommendationService</summary>
    public partial class RecommendationServiceClient : grpc::ClientBase<RecommendationServiceClient>
    {
      /// <summary>Creates a new client for RecommendationService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public RecommendationServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for RecommendationService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public RecommendationServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected RecommendationServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected RecommendationServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested recommendation in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Resources.Recommendation GetRecommendation(global::Google.Ads.GoogleAds.V0.Services.GetRecommendationRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetRecommendation(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested recommendation in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Resources.Recommendation GetRecommendation(global::Google.Ads.GoogleAds.V0.Services.GetRecommendationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetRecommendation, null, options, request);
      }
      /// <summary>
      /// Returns the requested recommendation in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Resources.Recommendation> GetRecommendationAsync(global::Google.Ads.GoogleAds.V0.Services.GetRecommendationRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetRecommendationAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested recommendation in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Resources.Recommendation> GetRecommendationAsync(global::Google.Ads.GoogleAds.V0.Services.GetRecommendationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetRecommendation, null, options, request);
      }
      /// <summary>
      /// Applies given recommendations with corresponding apply parameters.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Services.ApplyRecommendationResponse ApplyRecommendation(global::Google.Ads.GoogleAds.V0.Services.ApplyRecommendationRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ApplyRecommendation(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Applies given recommendations with corresponding apply parameters.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Services.ApplyRecommendationResponse ApplyRecommendation(global::Google.Ads.GoogleAds.V0.Services.ApplyRecommendationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ApplyRecommendation, null, options, request);
      }
      /// <summary>
      /// Applies given recommendations with corresponding apply parameters.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Services.ApplyRecommendationResponse> ApplyRecommendationAsync(global::Google.Ads.GoogleAds.V0.Services.ApplyRecommendationRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ApplyRecommendationAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Applies given recommendations with corresponding apply parameters.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Services.ApplyRecommendationResponse> ApplyRecommendationAsync(global::Google.Ads.GoogleAds.V0.Services.ApplyRecommendationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ApplyRecommendation, null, options, request);
      }
      /// <summary>
      /// Dismisses given recommendations.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Services.DismissRecommendationResponse DismissRecommendation(global::Google.Ads.GoogleAds.V0.Services.DismissRecommendationRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DismissRecommendation(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Dismisses given recommendations.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Services.DismissRecommendationResponse DismissRecommendation(global::Google.Ads.GoogleAds.V0.Services.DismissRecommendationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DismissRecommendation, null, options, request);
      }
      /// <summary>
      /// Dismisses given recommendations.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Services.DismissRecommendationResponse> DismissRecommendationAsync(global::Google.Ads.GoogleAds.V0.Services.DismissRecommendationRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DismissRecommendationAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Dismisses given recommendations.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Services.DismissRecommendationResponse> DismissRecommendationAsync(global::Google.Ads.GoogleAds.V0.Services.DismissRecommendationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DismissRecommendation, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override RecommendationServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new RecommendationServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(RecommendationServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetRecommendation, serviceImpl.GetRecommendation)
          .AddMethod(__Method_ApplyRecommendation, serviceImpl.ApplyRecommendation)
          .AddMethod(__Method_DismissRecommendation, serviceImpl.DismissRecommendation).Build();
    }

  }
}
#endregion