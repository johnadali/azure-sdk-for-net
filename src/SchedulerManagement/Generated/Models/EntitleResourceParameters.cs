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

namespace Microsoft.WindowsAzure.Management.Scheduler.Models
{
    public partial class EntitleResourceParameters
    {
        private DateTime _registrationDate;
        
        /// <summary>
        /// Required. The required data when the entitlement is performed.
        /// </summary>
        public DateTime RegistrationDate
        {
            get { return this._registrationDate; }
            set { this._registrationDate = value; }
        }
        
        private string _resourceNamespace;
        
        /// <summary>
        /// Required. Required NameSpace identifier for the resource provider.
        /// </summary>
        public string ResourceNamespace
        {
            get { return this._resourceNamespace; }
            set { this._resourceNamespace = value; }
        }
        
        private string _resourceType;
        
        /// <summary>
        /// Required. Required type for the resource.
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the EntitleResourceParameters class.
        /// </summary>
        public EntitleResourceParameters()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the EntitleResourceParameters class
        /// with required arguments.
        /// </summary>
        public EntitleResourceParameters(string resourceNamespace, string resourceType, DateTime registrationDate)
            : this()
        {
            if (resourceNamespace == null)
            {
                throw new ArgumentNullException("resourceNamespace");
            }
            if (resourceType == null)
            {
                throw new ArgumentNullException("resourceType");
            }
            this.ResourceNamespace = resourceNamespace;
            this.ResourceType = resourceType;
            this.RegistrationDate = registrationDate;
        }
    }
}
