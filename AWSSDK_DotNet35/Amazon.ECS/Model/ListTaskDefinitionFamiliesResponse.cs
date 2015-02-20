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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */

using System;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Configuration for accessing Amazon ListTaskDefinitionFamilies service
    /// </summary>
    public partial class ListTaskDefinitionFamiliesResponse : ListTaskDefinitionFamiliesResult
    {
        /// <summary>
        /// Gets and sets the ListTaskDefinitionFamiliesResult property.
        /// Represents the output of a ListTaskDefinitionFamilies operation.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the ListTaskDefinitionFamiliesResult class are now available on the ListTaskDefinitionFamiliesResponse class. You should use the properties on ListTaskDefinitionFamiliesResponse instead of accessing them through ListTaskDefinitionFamiliesResult.")]
        public ListTaskDefinitionFamiliesResult ListTaskDefinitionFamiliesResult
        {
            get
            {
                return this;
            }
        }
    }
}