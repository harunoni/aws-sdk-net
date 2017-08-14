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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePartition operation.
    /// Creates a new partition.
    /// </summary>
    public partial class CreatePartitionRequest : AmazonGlueRequest
    {
        private string _catalogId;
        private string _databaseName;
        private PartitionInput _partitionInput;
        private string _tableName;

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the catalog in which the partion is to be created. Currently, this should
        /// be the AWS account ID.
        /// </para>
        /// </summary>
        public string CatalogId
        {
            get { return this._catalogId; }
            set { this._catalogId = value; }
        }

        // Check to see if CatalogId property is set
        internal bool IsSetCatalogId()
        {
            return this._catalogId != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the metadata database in which the partition is to be created.
        /// </para>
        /// </summary>
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property PartitionInput. 
        /// <para>
        /// A <code>PartitionInput</code> structure defining the partition to be created.
        /// </para>
        /// </summary>
        public PartitionInput PartitionInput
        {
            get { return this._partitionInput; }
            set { this._partitionInput = value; }
        }

        // Check to see if PartitionInput property is set
        internal bool IsSetPartitionInput()
        {
            return this._partitionInput != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the metadata table in which the partition is to be created.
        /// </para>
        /// </summary>
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

    }
}