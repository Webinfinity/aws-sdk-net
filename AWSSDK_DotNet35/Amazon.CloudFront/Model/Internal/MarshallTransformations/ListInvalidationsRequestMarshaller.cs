/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

using Amazon.CloudFront.Model;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// List Invalidations Request Marshaller
    /// </summary>       
    public class ListInvalidationsRequestMarshaller : IMarshaller<IRequest, ListInvalidationsRequest>
    {
        
    
        public IRequest Marshall(ListInvalidationsRequest listInvalidationsRequest)
        {
            IRequest request = new DefaultRequest(listInvalidationsRequest, "AmazonCloudFront");



            request.HttpMethod = "GET";
            string uriResourcePath = "2013-11-11/distribution/{DistributionId}/invalidation?Marker={Marker}&MaxItems={MaxItems}"; 
            uriResourcePath = uriResourcePath.Replace("{DistributionId}", listInvalidationsRequest.IsSetDistributionId() ? listInvalidationsRequest.DistributionId.ToString() : "" ); 
            uriResourcePath = uriResourcePath.Replace("{Marker}", listInvalidationsRequest.IsSetMarker() ? listInvalidationsRequest.Marker.ToString() : "" ); 
            uriResourcePath = uriResourcePath.Replace("{MaxItems}", listInvalidationsRequest.IsSetMaxItems() ? listInvalidationsRequest.MaxItems.ToString() : "" ); 

            if (uriResourcePath.Contains("?")) 
            {
                int queryIndex = uriResourcePath.IndexOf("?", StringComparison.OrdinalIgnoreCase);
                string queryString = uriResourcePath.Substring(queryIndex + 1);
                
                uriResourcePath    = uriResourcePath.Substring(0, queryIndex);
                
        
                foreach (string s in queryString.Split('&', ';')) 
                {
                    string[] nameValuePair = s.Split('=');
                    if (nameValuePair.Length == 2)
                    {
                        if (nameValuePair[1].Length > 0)
                            request.Parameters.Add(nameValuePair[0], nameValuePair[1]);
                    }
                    else
                    {
                        request.Parameters.Add(nameValuePair[0], null);
                    }
                
                }
            }
            
            request.ResourcePath = uriResourcePath;
            
        
            request.UseQueryString = true;
            
            
            return request;
        }
    }
}
    
