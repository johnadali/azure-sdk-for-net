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
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.MediaServices;
using Microsoft.WindowsAzure.Management.MediaServices.Models;

namespace Microsoft.WindowsAzure.Management.MediaServices
{
    public static partial class AccountOperationsExtensions
    {
        /// <summary>
        /// The Create Media Services Account operation creates a new media
        /// services account in Windows Azure.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn194267.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.MediaServices.IAccountOperations.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Create Media Services Account operation.
        /// </param>
        /// <returns>
        /// The Create Media Services Account operation response.
        /// </returns>
        public static MediaServicesAccountCreateResponse Create(this IAccountOperations operations, MediaServicesAccountCreateParameters parameters)
        {
            try
            {
                return operations.CreateAsync(parameters).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// The Create Media Services Account operation creates a new media
        /// services account in Windows Azure.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn194267.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.MediaServices.IAccountOperations.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Create Media Services Account operation.
        /// </param>
        /// <returns>
        /// The Create Media Services Account operation response.
        /// </returns>
        public static Task<MediaServicesAccountCreateResponse> CreateAsync(this IAccountOperations operations, MediaServicesAccountCreateParameters parameters)
        {
            return operations.CreateAsync(parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// The Delete Media Services Account operation deletes an existing
        /// media services account in Windows Azure.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn194273.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.MediaServices.IAccountOperations.
        /// </param>
        /// <param name='accountName'>
        /// The name of the media services account.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse Delete(this IAccountOperations operations, string accountName)
        {
            try
            {
                return operations.DeleteAsync(accountName).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// The Delete Media Services Account operation deletes an existing
        /// media services account in Windows Azure.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn194273.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.MediaServices.IAccountOperations.
        /// </param>
        /// <param name='accountName'>
        /// The name of the media services account.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> DeleteAsync(this IAccountOperations operations, string accountName)
        {
            return operations.DeleteAsync(accountName, CancellationToken.None);
        }
        
        /// <summary>
        /// The Get Media Services Account operation gets detailed information
        /// about a media services account in Windows Azure.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166974.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.MediaServices.IAccountOperations.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Media Services account.
        /// </param>
        /// <returns>
        /// The Get Media Services Account operation response.
        /// </returns>
        public static MediaServicesAccountGetResponse Get(this IAccountOperations operations, string accountName)
        {
            try
            {
                return operations.GetAsync(accountName).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// The Get Media Services Account operation gets detailed information
        /// about a media services account in Windows Azure.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166974.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.MediaServices.IAccountOperations.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Media Services account.
        /// </param>
        /// <returns>
        /// The Get Media Services Account operation response.
        /// </returns>
        public static Task<MediaServicesAccountGetResponse> GetAsync(this IAccountOperations operations, string accountName)
        {
            return operations.GetAsync(accountName, CancellationToken.None);
        }
        
        /// <summary>
        /// The List Media Services Account operation gets information about
        /// all existing media services accounts associated with the current
        /// subscription in Windows Azure.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166989.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.MediaServices.IAccountOperations.
        /// </param>
        /// <returns>
        /// The List Media Accounts operation response.
        /// </returns>
        public static MediaServicesAccountListResponse List(this IAccountOperations operations)
        {
            try
            {
                return operations.ListAsync().Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// The List Media Services Account operation gets information about
        /// all existing media services accounts associated with the current
        /// subscription in Windows Azure.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166989.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.MediaServices.IAccountOperations.
        /// </param>
        /// <returns>
        /// The List Media Accounts operation response.
        /// </returns>
        public static Task<MediaServicesAccountListResponse> ListAsync(this IAccountOperations operations)
        {
            return operations.ListAsync(CancellationToken.None);
        }
        
        /// <summary>
        /// The Regenerate Media Services Account Key operation regenerates an
        /// account key for the given Media Services account in Windows Azure.
        /// (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn167010.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.MediaServices.IAccountOperations.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Media Services Account.
        /// </param>
        /// <param name='keyType'>
        /// The type of key to regenerate (primary or secondary)
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse RegenerateKey(this IAccountOperations operations, string accountName, MediaServicesKeyType keyType)
        {
            try
            {
                return operations.RegenerateKeyAsync(accountName, keyType).Result;
            }
            catch (AggregateException ex)
            {
                if (ex.InnerExceptions.Count > 1)
                {
                    throw;
                }
                else
                {
                    throw ex.InnerException;
                }
            }
        }
        
        /// <summary>
        /// The Regenerate Media Services Account Key operation regenerates an
        /// account key for the given Media Services account in Windows Azure.
        /// (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn167010.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.MediaServices.IAccountOperations.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Media Services Account.
        /// </param>
        /// <param name='keyType'>
        /// The type of key to regenerate (primary or secondary)
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> RegenerateKeyAsync(this IAccountOperations operations, string accountName, MediaServicesKeyType keyType)
        {
            return operations.RegenerateKeyAsync(accountName, keyType, CancellationToken.None);
        }
    }
}
