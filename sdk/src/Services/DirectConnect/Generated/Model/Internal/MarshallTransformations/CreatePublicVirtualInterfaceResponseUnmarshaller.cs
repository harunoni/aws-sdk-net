/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DirectConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DirectConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CreatePublicVirtualInterface operation
    /// </summary>  
    public class CreatePublicVirtualInterfaceResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            CreatePublicVirtualInterfaceResponse response = new CreatePublicVirtualInterfaceResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("addressFamily", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AddressFamily = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("amazonAddress", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AmazonAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("asn", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.Asn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("authKey", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AuthKey = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("bgpPeers", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<BGPPeer, BGPPeerUnmarshaller>(BGPPeerUnmarshaller.Instance);
                    response.BgpPeers = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("connectionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ConnectionId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("customerAddress", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.CustomerAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("customerRouterConfig", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.CustomerRouterConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("location", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Location = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ownerAccount", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.OwnerAccount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("routeFilterPrefixes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RouteFilterPrefix, RouteFilterPrefixUnmarshaller>(RouteFilterPrefixUnmarshaller.Instance);
                    response.RouteFilterPrefixes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("virtualGatewayId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.VirtualGatewayId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("virtualInterfaceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.VirtualInterfaceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("virtualInterfaceName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.VirtualInterfaceName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("virtualInterfaceState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.VirtualInterfaceState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("virtualInterfaceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.VirtualInterfaceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vlan", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.Vlan = unmarshaller.Unmarshall(context);
                    continue;
                }
            }

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("DirectConnectClientException"))
            {
                return new DirectConnectClientException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("DirectConnectServerException"))
            {
                return new DirectConnectServerException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonDirectConnectException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static CreatePublicVirtualInterfaceResponseUnmarshaller _instance = new CreatePublicVirtualInterfaceResponseUnmarshaller();        

        internal static CreatePublicVirtualInterfaceResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreatePublicVirtualInterfaceResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}