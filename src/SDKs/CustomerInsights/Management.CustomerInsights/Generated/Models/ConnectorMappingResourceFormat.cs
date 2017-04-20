// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.CustomerInsights.Models
{
    using Azure;
    using Management;
    using CustomerInsights;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The c onnector mapping resource format.
    /// </summary>
    [JsonTransformation]
    public partial class ConnectorMappingResourceFormat : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the ConnectorMappingResourceFormat
        /// class.
        /// </summary>
        public ConnectorMappingResourceFormat()
        {
            MappingProperties = new ConnectorMappingProperties();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectorMappingResourceFormat
        /// class.
        /// </summary>
        /// <param name="entityType">Defines which entity type the file should
        /// map to. Possible values include: 'None', 'Profile', 'Interaction',
        /// 'Relationship'</param>
        /// <param name="entityTypeName">The mapping entity name.</param>
        /// <param name="mappingProperties">The properties of the
        /// mapping.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="connectorName">The connector name.</param>
        /// <param name="connectorType">Type of connector. Possible values
        /// include: 'CRM', 'AzureBlob', 'Salesforce'</param>
        /// <param name="created">The created time.</param>
        /// <param name="lastModified">The last monified time.</param>
        /// <param name="connectorMappingName">The connector mapping
        /// name</param>
        /// <param name="displayName">Display name for the connector
        /// mapping.</param>
        /// <param name="description">The description of the connector
        /// mapping.</param>
        /// <param name="dataFormatId">The DataFormat ID.</param>
        /// <param name="nextRunTime">The next run time based on customer's
        /// settings.</param>
        /// <param name="runId">The RunId.</param>
        /// <param name="state">State of connector mapping. Possible values
        /// include: 'Creating', 'Created', 'Failed', 'Ready', 'Running',
        /// 'Stopped', 'Expiring'</param>
        /// <param name="tenantId">The hub name.</param>
        public ConnectorMappingResourceFormat(EntityTypes entityType, string entityTypeName, ConnectorMappingProperties mappingProperties, string id = default(string), string name = default(string), string type = default(string), string connectorName = default(string), ConnectorTypes? connectorType = default(ConnectorTypes?), System.DateTime? created = default(System.DateTime?), System.DateTime? lastModified = default(System.DateTime?), string connectorMappingName = default(string), string displayName = default(string), string description = default(string), string dataFormatId = default(string), System.DateTime? nextRunTime = default(System.DateTime?), string runId = default(string), ConnectorMappingStates? state = default(ConnectorMappingStates?), string tenantId = default(string))
            : base(id, name, type)
        {
            MappingProperties = new ConnectorMappingProperties();
            ConnectorName = connectorName;
            ConnectorType = connectorType;
            Created = created;
            LastModified = lastModified;
            EntityType = entityType;
            EntityTypeName = entityTypeName;
            ConnectorMappingName = connectorMappingName;
            DisplayName = displayName;
            Description = description;
            DataFormatId = dataFormatId;
            MappingProperties = mappingProperties;
            NextRunTime = nextRunTime;
            RunId = runId;
            State = state;
            TenantId = tenantId;
        }

        /// <summary>
        /// Gets the connector name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectorName")]
        public string ConnectorName { get; protected set; }

        /// <summary>
        /// Gets or sets type of connector. Possible values include: 'CRM',
        /// 'AzureBlob', 'Salesforce'
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectorType")]
        public ConnectorTypes? ConnectorType { get; set; }

        /// <summary>
        /// Gets the created time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.created")]
        public System.DateTime? Created { get; protected set; }

        /// <summary>
        /// Gets the last monified time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModified")]
        public System.DateTime? LastModified { get; protected set; }

        /// <summary>
        /// Gets or sets defines which entity type the file should map to.
        /// Possible values include: 'None', 'Profile', 'Interaction',
        /// 'Relationship'
        /// </summary>
        [JsonProperty(PropertyName = "properties.entityType")]
        public EntityTypes EntityType { get; set; }

        /// <summary>
        /// Gets or sets the mapping entity name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.entityTypeName")]
        public string EntityTypeName { get; set; }

        /// <summary>
        /// Gets the connector mapping name
        /// </summary>
        [JsonProperty(PropertyName = "properties.connectorMappingName")]
        public string ConnectorMappingName { get; protected set; }

        /// <summary>
        /// Gets or sets display name for the connector mapping.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the description of the connector mapping.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets the DataFormat ID.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataFormatId")]
        public string DataFormatId { get; protected set; }

        /// <summary>
        /// Gets or sets the properties of the mapping.
        /// </summary>
        [JsonProperty(PropertyName = "properties.mappingProperties")]
        public ConnectorMappingProperties MappingProperties { get; set; }

        /// <summary>
        /// Gets the next run time based on customer's settings.
        /// </summary>
        [JsonProperty(PropertyName = "properties.nextRunTime")]
        public System.DateTime? NextRunTime { get; protected set; }

        /// <summary>
        /// Gets the RunId.
        /// </summary>
        [JsonProperty(PropertyName = "properties.runId")]
        public string RunId { get; protected set; }

        /// <summary>
        /// Gets state of connector mapping. Possible values include:
        /// 'Creating', 'Created', 'Failed', 'Ready', 'Running', 'Stopped',
        /// 'Expiring'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public ConnectorMappingStates? State { get; protected set; }

        /// <summary>
        /// Gets the hub name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tenantId")]
        public string TenantId { get; protected set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (EntityTypeName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "EntityTypeName");
            }
            if (MappingProperties == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MappingProperties");
            }
            if (MappingProperties != null)
            {
                MappingProperties.Validate();
            }
        }
    }
}
