// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.OperationalInsights;
using Microsoft.Azure.Management.OperationalInsights.Models;

namespace Microsoft.Azure.Management.OperationalInsights
{
    /// <summary>
    /// .Net client wrapper for the REST API for Azure Operational Insights
    /// </summary>
    public static partial class WorkspaceOperationsExtensions
    {
        /// <summary>
        /// Create or update a workspace.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.IWorkspaceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspace.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update a workspace.
        /// </param>
        /// <returns>
        /// The create or update workspace operation response.
        /// </returns>
        public static WorkspaceCreateOrUpdateResponse BeginCreateOrUpdate(this IWorkspaceOperations operations, string resourceGroupName, WorkspaceCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IWorkspaceOperations)s).BeginCreateOrUpdateAsync(resourceGroupName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create or update a workspace.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.IWorkspaceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspace.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update a workspace.
        /// </param>
        /// <returns>
        /// The create or update workspace operation response.
        /// </returns>
        public static Task<WorkspaceCreateOrUpdateResponse> BeginCreateOrUpdateAsync(this IWorkspaceOperations operations, string resourceGroupName, WorkspaceCreateOrUpdateParameters parameters)
        {
            return operations.BeginCreateOrUpdateAsync(resourceGroupName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Create or update a workspace.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.IWorkspaceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspace.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update a workspace.
        /// </param>
        /// <returns>
        /// The create or update workspace operation response.
        /// </returns>
        public static WorkspaceCreateOrUpdateResponse CreateOrUpdate(this IWorkspaceOperations operations, string resourceGroupName, WorkspaceCreateOrUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IWorkspaceOperations)s).CreateOrUpdateAsync(resourceGroupName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create or update a workspace.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.IWorkspaceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspace.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters required to create or update a workspace.
        /// </param>
        /// <returns>
        /// The create or update workspace operation response.
        /// </returns>
        public static Task<WorkspaceCreateOrUpdateResponse> CreateOrUpdateAsync(this IWorkspaceOperations operations, string resourceGroupName, WorkspaceCreateOrUpdateParameters parameters)
        {
            return operations.CreateOrUpdateAsync(resourceGroupName, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Deletes a workspace instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.IWorkspaceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspace.
        /// </param>
        /// <param name='workspaceName'>
        /// Required. A unique workspace instance name.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Delete(this IWorkspaceOperations operations, string resourceGroupName, string workspaceName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IWorkspaceOperations)s).DeleteAsync(resourceGroupName, workspaceName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Deletes a workspace instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.IWorkspaceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspace.
        /// </param>
        /// <param name='workspaceName'>
        /// Required. A unique workspace instance name.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteAsync(this IWorkspaceOperations operations, string resourceGroupName, string workspaceName)
        {
            return operations.DeleteAsync(resourceGroupName, workspaceName, CancellationToken.None);
        }
        
        /// <summary>
        /// Disables an intelligence back for a given workspace.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.IWorkspaceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspace.
        /// </param>
        /// <param name='workspaceName'>
        /// Required. A unique workspace instance name.
        /// </param>
        /// <param name='intelligencePackName'>
        /// Required. The name of the intelligence pack to be disabled.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse DisableIntelligencePack(this IWorkspaceOperations operations, string resourceGroupName, string workspaceName, string intelligencePackName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IWorkspaceOperations)s).DisableIntelligencePackAsync(resourceGroupName, workspaceName, intelligencePackName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Disables an intelligence back for a given workspace.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.IWorkspaceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspace.
        /// </param>
        /// <param name='workspaceName'>
        /// Required. A unique workspace instance name.
        /// </param>
        /// <param name='intelligencePackName'>
        /// Required. The name of the intelligence pack to be disabled.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DisableIntelligencePackAsync(this IWorkspaceOperations operations, string resourceGroupName, string workspaceName, string intelligencePackName)
        {
            return operations.DisableIntelligencePackAsync(resourceGroupName, workspaceName, intelligencePackName, CancellationToken.None);
        }
        
        /// <summary>
        /// Enables an intelligence back for a given workspace.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.IWorkspaceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspace.
        /// </param>
        /// <param name='workspaceName'>
        /// Required. A unique workspace instance name.
        /// </param>
        /// <param name='intelligencePackName'>
        /// Required. The name of the intelligence pack to be enabled.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse EnableIntelligencePack(this IWorkspaceOperations operations, string resourceGroupName, string workspaceName, string intelligencePackName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IWorkspaceOperations)s).EnableIntelligencePackAsync(resourceGroupName, workspaceName, intelligencePackName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Enables an intelligence back for a given workspace.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.IWorkspaceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspace.
        /// </param>
        /// <param name='workspaceName'>
        /// Required. A unique workspace instance name.
        /// </param>
        /// <param name='intelligencePackName'>
        /// Required. The name of the intelligence pack to be enabled.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> EnableIntelligencePackAsync(this IWorkspaceOperations operations, string resourceGroupName, string workspaceName, string intelligencePackName)
        {
            return operations.EnableIntelligencePackAsync(resourceGroupName, workspaceName, intelligencePackName, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets a workspace instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.IWorkspaceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspace.
        /// </param>
        /// <param name='workspaceName'>
        /// Required. A unique workspace instance name.
        /// </param>
        /// <returns>
        /// The get workspace operation response.
        /// </returns>
        public static WorkspaceGetResponse Get(this IWorkspaceOperations operations, string resourceGroupName, string workspaceName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IWorkspaceOperations)s).GetAsync(resourceGroupName, workspaceName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets a workspace instance.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.IWorkspaceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspace.
        /// </param>
        /// <param name='workspaceName'>
        /// Required. A unique workspace instance name.
        /// </param>
        /// <returns>
        /// The get workspace operation response.
        /// </returns>
        public static Task<WorkspaceGetResponse> GetAsync(this IWorkspaceOperations operations, string resourceGroupName, string workspaceName)
        {
            return operations.GetAsync(resourceGroupName, workspaceName, CancellationToken.None);
        }
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.IWorkspaceOperations.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the BeginCreateOrUpdate
        /// operation.
        /// </param>
        /// <returns>
        /// The create or update workspace operation response.
        /// </returns>
        public static WorkspaceCreateOrUpdateResponse GetCreateOrUpdateStatus(this IWorkspaceOperations operations, string operationStatusLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IWorkspaceOperations)s).GetCreateOrUpdateStatusAsync(operationStatusLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.IWorkspaceOperations.
        /// </param>
        /// <param name='operationStatusLink'>
        /// Required. Location value returned by the BeginCreateOrUpdate
        /// operation.
        /// </param>
        /// <returns>
        /// The create or update workspace operation response.
        /// </returns>
        public static Task<WorkspaceCreateOrUpdateResponse> GetCreateOrUpdateStatusAsync(this IWorkspaceOperations operations, string operationStatusLink)
        {
            return operations.GetCreateOrUpdateStatusAsync(operationStatusLink, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the shared keys for a workspace.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.IWorkspaceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspace.
        /// </param>
        /// <param name='workspaceName'>
        /// Required. A unique workspace name.
        /// </param>
        /// <returns>
        /// The get workspace shared keys operation response.
        /// </returns>
        public static WorkspaceGetSharedKeysResponse GetSharedKeys(this IWorkspaceOperations operations, string resourceGroupName, string workspaceName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IWorkspaceOperations)s).GetSharedKeysAsync(resourceGroupName, workspaceName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the shared keys for a workspace.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.IWorkspaceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspace.
        /// </param>
        /// <param name='workspaceName'>
        /// Required. A unique workspace name.
        /// </param>
        /// <returns>
        /// The get workspace shared keys operation response.
        /// </returns>
        public static Task<WorkspaceGetSharedKeysResponse> GetSharedKeysAsync(this IWorkspaceOperations operations, string resourceGroupName, string workspaceName)
        {
            return operations.GetSharedKeysAsync(resourceGroupName, workspaceName, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the first page of workspace instances in a resource group with
        /// the link to the next page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.IWorkspaceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspaces.
        /// </param>
        /// <returns>
        /// The list workspaces operation response.
        /// </returns>
        public static WorkspaceListResponse ListInResourceGroup(this IWorkspaceOperations operations, string resourceGroupName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IWorkspaceOperations)s).ListInResourceGroupAsync(resourceGroupName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the first page of workspace instances in a resource group with
        /// the link to the next page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.IWorkspaceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspaces.
        /// </param>
        /// <returns>
        /// The list workspaces operation response.
        /// </returns>
        public static Task<WorkspaceListResponse> ListInResourceGroupAsync(this IWorkspaceOperations operations, string resourceGroupName)
        {
            return operations.ListInResourceGroupAsync(resourceGroupName, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the first page of workspace instances in a subscription with
        /// the link to the next page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.IWorkspaceOperations.
        /// </param>
        /// <returns>
        /// The list workspaces operation response.
        /// </returns>
        public static WorkspaceListResponse ListInSubscription(this IWorkspaceOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IWorkspaceOperations)s).ListInSubscriptionAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the first page of workspace instances in a subscription with
        /// the link to the next page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.IWorkspaceOperations.
        /// </param>
        /// <returns>
        /// The list workspaces operation response.
        /// </returns>
        public static Task<WorkspaceListResponse> ListInSubscriptionAsync(this IWorkspaceOperations operations)
        {
            return operations.ListInSubscriptionAsync(CancellationToken.None);
        }
        
        /// <summary>
        /// Lists all the intelligence packs possible and whether they are
        /// enabled or disabled for a given workspace.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.IWorkspaceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspace.
        /// </param>
        /// <param name='workspaceName'>
        /// Required. A unique workspace instance name.
        /// </param>
        /// <returns>
        /// The list intelligence packs operation response.
        /// </returns>
        public static WorkspaceListIntelligencePacksResponse ListIntelligencePacks(this IWorkspaceOperations operations, string resourceGroupName, string workspaceName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IWorkspaceOperations)s).ListIntelligencePacksAsync(resourceGroupName, workspaceName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Lists all the intelligence packs possible and whether they are
        /// enabled or disabled for a given workspace.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.IWorkspaceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspace.
        /// </param>
        /// <param name='workspaceName'>
        /// Required. A unique workspace instance name.
        /// </param>
        /// <returns>
        /// The list intelligence packs operation response.
        /// </returns>
        public static Task<WorkspaceListIntelligencePacksResponse> ListIntelligencePacksAsync(this IWorkspaceOperations operations, string resourceGroupName, string workspaceName)
        {
            return operations.ListIntelligencePacksAsync(resourceGroupName, workspaceName, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets a list of accounts with administrator privileges that are not
        /// associated with an existing workspace.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.IWorkspaceOperations.
        /// </param>
        /// <returns>
        /// The list workspace link targets operation response.
        /// </returns>
        public static WorkspaceListLinkTargetsResponse ListLinkTargets(this IWorkspaceOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IWorkspaceOperations)s).ListLinkTargetsAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets a list of accounts with administrator privileges that are not
        /// associated with an existing workspace.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.IWorkspaceOperations.
        /// </param>
        /// <returns>
        /// The list workspace link targets operation response.
        /// </returns>
        public static Task<WorkspaceListLinkTargetsResponse> ListLinkTargetsAsync(this IWorkspaceOperations operations)
        {
            return operations.ListLinkTargetsAsync(CancellationToken.None);
        }
        
        /// <summary>
        /// Gets a list of management groups connected to a workspace.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.IWorkspaceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspace.
        /// </param>
        /// <param name='workspaceName'>
        /// Required. The name of the workspace.
        /// </param>
        /// <returns>
        /// The list workspace managmement groups operation response.
        /// </returns>
        public static WorkspaceListManagementGroupsResponse ListManagementGroups(this IWorkspaceOperations operations, string resourceGroupName, string workspaceName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IWorkspaceOperations)s).ListManagementGroupsAsync(resourceGroupName, workspaceName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets a list of management groups connected to a workspace.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.IWorkspaceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspace.
        /// </param>
        /// <param name='workspaceName'>
        /// Required. The name of the workspace.
        /// </param>
        /// <returns>
        /// The list workspace managmement groups operation response.
        /// </returns>
        public static Task<WorkspaceListManagementGroupsResponse> ListManagementGroupsAsync(this IWorkspaceOperations operations, string resourceGroupName, string workspaceName)
        {
            return operations.ListManagementGroupsAsync(resourceGroupName, workspaceName, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the next page of workspace instances with the link to the next
        /// page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.IWorkspaceOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The url to the next workspaces page.
        /// </param>
        /// <returns>
        /// The list workspaces operation response.
        /// </returns>
        public static WorkspaceListResponse ListNext(this IWorkspaceOperations operations, string nextLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IWorkspaceOperations)s).ListNextAsync(nextLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the next page of workspace instances with the link to the next
        /// page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.IWorkspaceOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The url to the next workspaces page.
        /// </param>
        /// <returns>
        /// The list workspaces operation response.
        /// </returns>
        public static Task<WorkspaceListResponse> ListNextAsync(this IWorkspaceOperations operations, string nextLink)
        {
            return operations.ListNextAsync(nextLink, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets the next page of management groups with the link to the next
        /// page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.IWorkspaceOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The url to the next management groups page.
        /// </param>
        /// <returns>
        /// The list workspace managmement groups operation response.
        /// </returns>
        public static WorkspaceListManagementGroupsResponse ListNextManagementGroups(this IWorkspaceOperations operations, string nextLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IWorkspaceOperations)s).ListNextManagementGroupsAsync(nextLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets the next page of management groups with the link to the next
        /// page.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.IWorkspaceOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The url to the next management groups page.
        /// </param>
        /// <returns>
        /// The list workspace managmement groups operation response.
        /// </returns>
        public static Task<WorkspaceListManagementGroupsResponse> ListNextManagementGroupsAsync(this IWorkspaceOperations operations, string nextLink)
        {
            return operations.ListNextManagementGroupsAsync(nextLink, CancellationToken.None);
        }
        
        /// <summary>
        /// Gets a list of usage metrics for a workspace.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.IWorkspaceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspace.
        /// </param>
        /// <param name='workspaceName'>
        /// Required. The name of the workspace.
        /// </param>
        /// <returns>
        /// The list workspace usages operation response.
        /// </returns>
        public static WorkspaceListUsagesResponse ListUsages(this IWorkspaceOperations operations, string resourceGroupName, string workspaceName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IWorkspaceOperations)s).ListUsagesAsync(resourceGroupName, workspaceName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Gets a list of usage metrics for a workspace.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.OperationalInsights.IWorkspaceOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The resource group name of the workspace.
        /// </param>
        /// <param name='workspaceName'>
        /// Required. The name of the workspace.
        /// </param>
        /// <returns>
        /// The list workspace usages operation response.
        /// </returns>
        public static Task<WorkspaceListUsagesResponse> ListUsagesAsync(this IWorkspaceOperations operations, string resourceGroupName, string workspaceName)
        {
            return operations.ListUsagesAsync(resourceGroupName, workspaceName, CancellationToken.None);
        }
    }
}
