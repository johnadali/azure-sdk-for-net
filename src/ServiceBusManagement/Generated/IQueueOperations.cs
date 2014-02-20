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
using Microsoft.WindowsAzure.Management.ServiceBus.Models;

namespace Microsoft.WindowsAzure.Management.ServiceBus
{
    /// <summary>
    /// The Service Bus Management API includes operations for managing Service
    /// Bus queues.
    /// </summary>
    public partial interface IQueueOperations
    {
        /// <summary>
        /// Creates a new queue. Once created, this queue’s resource manifest
        /// is immutable. This operation is idempotent. Repeating the create
        /// call, after a queue with same name has been created successfully,
        /// will result in a 409 Conflict error message.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj856295.aspx
        /// for more information)
        /// </summary>
        /// <param name='namespaceName'>
        /// The namespace name.
        /// </param>
        /// <param name='queue'>
        /// The service bus queue.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A response to a request for a particular queue.
        /// </returns>
        Task<ServiceBusQueueResponse> CreateAsync(string namespaceName, ServiceBusQueue queue, CancellationToken cancellationToken);
        
        /// <summary>
        /// The queue description is an XML AtomPub document that defines the
        /// desired semantics for a subscription. The queue description
        /// contains the following properties. For more information, see the
        /// QueueDescription Properties topic.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/hh780773.aspx
        /// for more information)
        /// </summary>
        /// <param name='namespaceName'>
        /// The namespace name.
        /// </param>
        /// <param name='queueName'>
        /// The queue name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A response to a request for a particular queue.
        /// </returns>
        Task<ServiceBusQueueResponse> GetAsync(string namespaceName, string queueName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the set of connection strings for a queue.
        /// </summary>
        /// <param name='namespaceName'>
        /// The namespace name.
        /// </param>
        /// <param name='queueName'>
        /// The queue name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The set of connection details for a service bus entity.
        /// </returns>
        Task<ServiceBusConnectionDetailsResponse> GetConnectionDetailsAsync(string namespaceName, string queueName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Enumerates the queues in the service namespace. The result is
        /// returned in pages, each containing up to 100 queues. If the
        /// namespace contains more than 100 queues, a feed is returned that
        /// contains the first page and a next link with the URI to view the
        /// next page of data.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/hh780759.asp
        /// for more information)
        /// </summary>
        /// <param name='namespaceName'>
        /// The namespace name.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A response to a request for a list of queues.
        /// </returns>
        Task<ServiceBusQueuesResponse> ListAsync(string namespaceName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Updates the queue description and makes a call to update
        /// corresponding DB entries.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/jj856305.aspx
        /// for more information)
        /// </summary>
        /// <param name='namespaceName'>
        /// The namespace name.
        /// </param>
        /// <param name='queue'>
        /// The service bus queue.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A response to a request for a particular queue.
        /// </returns>
        Task<ServiceBusQueueResponse> UpdateAsync(string namespaceName, ServiceBusQueue queue, CancellationToken cancellationToken);
    }
}
