// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.SignalR
{
    /// <summary>
    /// A class representing a collection of <see cref="SharedPrivateLinkResource" /> and their operations.
    /// Each <see cref="SharedPrivateLinkResource" /> in the collection will belong to the same instance of <see cref="SignalRResource" />.
    /// To get a <see cref="SharedPrivateLinkResourceCollection" /> instance call the GetSharedPrivateLinkResources method from an instance of <see cref="SignalRResource" />.
    /// </summary>
    public partial class SharedPrivateLinkResourceCollection : ArmCollection, IEnumerable<SharedPrivateLinkResource>, IAsyncEnumerable<SharedPrivateLinkResource>
    {
        private readonly ClientDiagnostics _sharedPrivateLinkResourceSignalRSharedPrivateLinkResourcesClientDiagnostics;
        private readonly SignalRSharedPrivateLinkResourcesRestOperations _sharedPrivateLinkResourceSignalRSharedPrivateLinkResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SharedPrivateLinkResourceCollection"/> class for mocking. </summary>
        protected SharedPrivateLinkResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SharedPrivateLinkResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SharedPrivateLinkResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sharedPrivateLinkResourceSignalRSharedPrivateLinkResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SignalR", SharedPrivateLinkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SharedPrivateLinkResource.ResourceType, out string sharedPrivateLinkResourceSignalRSharedPrivateLinkResourcesApiVersion);
            _sharedPrivateLinkResourceSignalRSharedPrivateLinkResourcesRestClient = new SignalRSharedPrivateLinkResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sharedPrivateLinkResourceSignalRSharedPrivateLinkResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SignalRResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SignalRResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a shared private link resource
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}/sharedPrivateLinkResources/{sharedPrivateLinkResourceName}
        /// Operation Id: SignalRSharedPrivateLinkResources_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sharedPrivateLinkResourceName"> The name of the shared private link resource. </param>
        /// <param name="data"> The shared private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkResourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SharedPrivateLinkResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string sharedPrivateLinkResourceName, SharedPrivateLinkResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkResourceName, nameof(sharedPrivateLinkResourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sharedPrivateLinkResourceSignalRSharedPrivateLinkResourcesClientDiagnostics.CreateScope("SharedPrivateLinkResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sharedPrivateLinkResourceSignalRSharedPrivateLinkResourcesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SignalRArmOperation<SharedPrivateLinkResource>(new SharedPrivateLinkResourceOperationSource(Client), _sharedPrivateLinkResourceSignalRSharedPrivateLinkResourcesClientDiagnostics, Pipeline, _sharedPrivateLinkResourceSignalRSharedPrivateLinkResourcesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update a shared private link resource
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}/sharedPrivateLinkResources/{sharedPrivateLinkResourceName}
        /// Operation Id: SignalRSharedPrivateLinkResources_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sharedPrivateLinkResourceName"> The name of the shared private link resource. </param>
        /// <param name="data"> The shared private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkResourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SharedPrivateLinkResource> CreateOrUpdate(WaitUntil waitUntil, string sharedPrivateLinkResourceName, SharedPrivateLinkResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkResourceName, nameof(sharedPrivateLinkResourceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sharedPrivateLinkResourceSignalRSharedPrivateLinkResourcesClientDiagnostics.CreateScope("SharedPrivateLinkResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sharedPrivateLinkResourceSignalRSharedPrivateLinkResourcesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, data, cancellationToken);
                var operation = new SignalRArmOperation<SharedPrivateLinkResource>(new SharedPrivateLinkResourceOperationSource(Client), _sharedPrivateLinkResourceSignalRSharedPrivateLinkResourcesClientDiagnostics, Pipeline, _sharedPrivateLinkResourceSignalRSharedPrivateLinkResourcesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified shared private link resource
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}/sharedPrivateLinkResources/{sharedPrivateLinkResourceName}
        /// Operation Id: SignalRSharedPrivateLinkResources_Get
        /// </summary>
        /// <param name="sharedPrivateLinkResourceName"> The name of the shared private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkResourceName"/> is null. </exception>
        public virtual async Task<Response<SharedPrivateLinkResource>> GetAsync(string sharedPrivateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkResourceName, nameof(sharedPrivateLinkResourceName));

            using var scope = _sharedPrivateLinkResourceSignalRSharedPrivateLinkResourcesClientDiagnostics.CreateScope("SharedPrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _sharedPrivateLinkResourceSignalRSharedPrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SharedPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified shared private link resource
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}/sharedPrivateLinkResources/{sharedPrivateLinkResourceName}
        /// Operation Id: SignalRSharedPrivateLinkResources_Get
        /// </summary>
        /// <param name="sharedPrivateLinkResourceName"> The name of the shared private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkResourceName"/> is null. </exception>
        public virtual Response<SharedPrivateLinkResource> Get(string sharedPrivateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkResourceName, nameof(sharedPrivateLinkResourceName));

            using var scope = _sharedPrivateLinkResourceSignalRSharedPrivateLinkResourcesClientDiagnostics.CreateScope("SharedPrivateLinkResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _sharedPrivateLinkResourceSignalRSharedPrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SharedPrivateLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List shared private link resources
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}/sharedPrivateLinkResources
        /// Operation Id: SignalRSharedPrivateLinkResources_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SharedPrivateLinkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SharedPrivateLinkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SharedPrivateLinkResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sharedPrivateLinkResourceSignalRSharedPrivateLinkResourcesClientDiagnostics.CreateScope("SharedPrivateLinkResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sharedPrivateLinkResourceSignalRSharedPrivateLinkResourcesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SharedPrivateLinkResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SharedPrivateLinkResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sharedPrivateLinkResourceSignalRSharedPrivateLinkResourcesClientDiagnostics.CreateScope("SharedPrivateLinkResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sharedPrivateLinkResourceSignalRSharedPrivateLinkResourcesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SharedPrivateLinkResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// List shared private link resources
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}/sharedPrivateLinkResources
        /// Operation Id: SignalRSharedPrivateLinkResources_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SharedPrivateLinkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SharedPrivateLinkResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SharedPrivateLinkResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sharedPrivateLinkResourceSignalRSharedPrivateLinkResourcesClientDiagnostics.CreateScope("SharedPrivateLinkResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sharedPrivateLinkResourceSignalRSharedPrivateLinkResourcesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SharedPrivateLinkResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SharedPrivateLinkResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sharedPrivateLinkResourceSignalRSharedPrivateLinkResourcesClientDiagnostics.CreateScope("SharedPrivateLinkResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sharedPrivateLinkResourceSignalRSharedPrivateLinkResourcesRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SharedPrivateLinkResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}/sharedPrivateLinkResources/{sharedPrivateLinkResourceName}
        /// Operation Id: SignalRSharedPrivateLinkResources_Get
        /// </summary>
        /// <param name="sharedPrivateLinkResourceName"> The name of the shared private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkResourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string sharedPrivateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkResourceName, nameof(sharedPrivateLinkResourceName));

            using var scope = _sharedPrivateLinkResourceSignalRSharedPrivateLinkResourcesClientDiagnostics.CreateScope("SharedPrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sharedPrivateLinkResourceSignalRSharedPrivateLinkResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}/sharedPrivateLinkResources/{sharedPrivateLinkResourceName}
        /// Operation Id: SignalRSharedPrivateLinkResources_Get
        /// </summary>
        /// <param name="sharedPrivateLinkResourceName"> The name of the shared private link resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sharedPrivateLinkResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sharedPrivateLinkResourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string sharedPrivateLinkResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sharedPrivateLinkResourceName, nameof(sharedPrivateLinkResourceName));

            using var scope = _sharedPrivateLinkResourceSignalRSharedPrivateLinkResourcesClientDiagnostics.CreateScope("SharedPrivateLinkResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _sharedPrivateLinkResourceSignalRSharedPrivateLinkResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sharedPrivateLinkResourceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SharedPrivateLinkResource> IEnumerable<SharedPrivateLinkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SharedPrivateLinkResource> IAsyncEnumerable<SharedPrivateLinkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
