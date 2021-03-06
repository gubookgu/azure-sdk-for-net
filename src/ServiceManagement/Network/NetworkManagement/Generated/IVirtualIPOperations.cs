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

namespace Microsoft.WindowsAzure.Management.Network
{
    /// <summary>
    /// The Network Management API includes operations for managing the Virtual
    /// IPs for your deployment.
    /// </summary>
    public partial interface IVirtualIPOperations
    {
        /// <summary>
        /// The Add Virtual IP operation adds a logical Virtual IP to the
        /// deployment.
        /// </summary>
        /// <param name='serviceName'>
        /// The name of the hosted service that contains the given deployment.
        /// </param>
        /// <param name='deploymentName'>
        /// The name of the deployment where the logical Virtual IP is to be
        /// added.
        /// </param>
        /// <param name='virtualIPName'>
        /// The name of the logical Virtual IP to be added.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<OperationStatusResponse> AddAsync(string serviceName, string deploymentName, string virtualIPName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Begin Adding Virtual IP operation adds a logical Virtual IP to
        /// the deployment.
        /// </summary>
        /// <param name='serviceName'>
        /// The name of the hosted service that contains the given deployment.
        /// </param>
        /// <param name='deploymentName'>
        /// The name of the deployment where the logical Virtual IP is to be
        /// added.
        /// </param>
        /// <param name='virtualIPName'>
        /// The name of the logical Virtual IP to be added.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<OperationStatusResponse> BeginAddingAsync(string serviceName, string deploymentName, string virtualIPName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Begin Removing Virtual IP operation removes a logical Virtual
        /// IP from the deployment.
        /// </summary>
        /// <param name='serviceName'>
        /// The name of the hosted service that contains the given deployment.
        /// </param>
        /// <param name='deploymentName'>
        /// The name of the deployment whose logical Virtual IP is to be
        /// removed.
        /// </param>
        /// <param name='virtualIPName'>
        /// The name of the logical Virtual IP to be added.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<OperationStatusResponse> BeginRemovingAsync(string serviceName, string deploymentName, string virtualIPName, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Remove Virtual IP operation removes a logical Virtual IP from
        /// the deployment.
        /// </summary>
        /// <param name='serviceName'>
        /// The name of the hosted service that contains the given deployment.
        /// </param>
        /// <param name='deploymentName'>
        /// The name of the deployment whose logical Virtual IP is to be
        /// removed.
        /// </param>
        /// <param name='virtualIPName'>
        /// The name of the logical Virtual IP to be removed.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<OperationStatusResponse> RemoveAsync(string serviceName, string deploymentName, string virtualIPName, CancellationToken cancellationToken);
    }
}
