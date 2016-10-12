// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure.OData;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for ResourceLinksOperations.
    /// </summary>
    public static partial class ResourceLinksOperationsExtensions
    {
            /// <summary>
            /// Deletes a resource link.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='linkId'>
            /// The fully qualified Id of the resource link. For example,
            /// /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink
            /// </param>
            public static void DeleteById(this IResourceLinksOperations operations, string linkId)
            {
                Task.Factory.StartNew(s => ((IResourceLinksOperations)s).DeleteByIdAsync(linkId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a resource link.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='linkId'>
            /// The fully qualified Id of the resource link. For example,
            /// /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteByIdAsync(this IResourceLinksOperations operations, string linkId, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteByIdWithHttpMessagesAsync(linkId, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Create a resource link.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='linkId'>
            /// The fully qualified Id of the resource link. For example,
            /// /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink
            /// </param>
            /// <param name='parameters'>
            /// Create or update resource link parameters.
            /// </param>
            public static ResourceLink CreateOrUpdateById(this IResourceLinksOperations operations, string linkId, ResourceLink parameters)
            {
                return Task.Factory.StartNew(s => ((IResourceLinksOperations)s).CreateOrUpdateByIdAsync(linkId, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a resource link.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='linkId'>
            /// The fully qualified Id of the resource link. For example,
            /// /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink
            /// </param>
            /// <param name='parameters'>
            /// Create or update resource link parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ResourceLink> CreateOrUpdateByIdAsync(this IResourceLinksOperations operations, string linkId, ResourceLink parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateByIdWithHttpMessagesAsync(linkId, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a resource link.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='linkId'>
            /// The fully qualified Id of the resource link. For example,
            /// /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink
            /// </param>
            public static ResourceLink GetById(this IResourceLinksOperations operations, string linkId)
            {
                return Task.Factory.StartNew(s => ((IResourceLinksOperations)s).GetByIdAsync(linkId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a resource link.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='linkId'>
            /// The fully qualified Id of the resource link. For example,
            /// /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ResourceLink> GetByIdAsync(this IResourceLinksOperations operations, string linkId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByIdWithHttpMessagesAsync(linkId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of resource links under the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<ResourceLink> ListAtSubscription(this IResourceLinksOperations operations, ODataQuery<ResourceLinkFilter> odataQuery = default(ODataQuery<ResourceLinkFilter>))
            {
                return Task.Factory.StartNew(s => ((IResourceLinksOperations)s).ListAtSubscriptionAsync(odataQuery), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of resource links under the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ResourceLink>> ListAtSubscriptionAsync(this IResourceLinksOperations operations, ODataQuery<ResourceLinkFilter> odataQuery = default(ODataQuery<ResourceLinkFilter>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAtSubscriptionWithHttpMessagesAsync(odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of resource links at and below the specified source scope. For
            /// example, to list resource links at and under a resource group, set the
            /// scope to
            /// /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The fully qualified Id of the source resource scope. For example, to list
            /// resource links at and under a resource group, set the scope to
            /// /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<ResourceLink> ListAtSourceScope(this IResourceLinksOperations operations, string scope, ODataQuery<ResourceLinkFilter> odataQuery = default(ODataQuery<ResourceLinkFilter>))
            {
                return Task.Factory.StartNew(s => ((IResourceLinksOperations)s).ListAtSourceScopeAsync(scope, odataQuery), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of resource links at and below the specified source scope. For
            /// example, to list resource links at and under a resource group, set the
            /// scope to
            /// /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The fully qualified Id of the source resource scope. For example, to list
            /// resource links at and under a resource group, set the scope to
            /// /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ResourceLink>> ListAtSourceScopeAsync(this IResourceLinksOperations operations, string scope, ODataQuery<ResourceLinkFilter> odataQuery = default(ODataQuery<ResourceLinkFilter>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAtSourceScopeWithHttpMessagesAsync(scope, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of resource links under the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ResourceLink> ListAtSubscriptionNext(this IResourceLinksOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IResourceLinksOperations)s).ListAtSubscriptionNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of resource links under the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ResourceLink>> ListAtSubscriptionNextAsync(this IResourceLinksOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAtSubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of resource links at and below the specified source scope. For
            /// example, to list resource links at and under a resource group, set the
            /// scope to
            /// /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ResourceLink> ListAtSourceScopeNext(this IResourceLinksOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IResourceLinksOperations)s).ListAtSourceScopeNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of resource links at and below the specified source scope. For
            /// example, to list resource links at and under a resource group, set the
            /// scope to
            /// /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ResourceLink>> ListAtSourceScopeNextAsync(this IResourceLinksOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListAtSourceScopeNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
