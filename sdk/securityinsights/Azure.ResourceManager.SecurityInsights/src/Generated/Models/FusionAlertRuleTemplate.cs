// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents Fusion alert rule template. </summary>
    public partial class FusionAlertRuleTemplate : AlertRuleTemplateData
    {
        /// <summary> Initializes a new instance of FusionAlertRuleTemplate. </summary>
        public FusionAlertRuleTemplate()
        {
            RequiredDataConnectors = new ChangeTrackingList<AlertRuleTemplateDataSource>();
            Tactics = new ChangeTrackingList<AttackTactic>();
            Techniques = new ChangeTrackingList<string>();
            SourceSettings = new ChangeTrackingList<FusionTemplateSourceSetting>();
            Kind = AlertRuleKind.Fusion;
        }

        /// <summary> Initializes a new instance of FusionAlertRuleTemplate. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The kind of the alert rule. </param>
        /// <param name="alertRulesCreatedByTemplateCount"> the number of alert rules that were created by this template. </param>
        /// <param name="createdDateUTC"> The time that this alert rule template has been added. </param>
        /// <param name="lastUpdatedDateUTC"> The time that this alert rule template was last updated. </param>
        /// <param name="description"> The description of the alert rule template. </param>
        /// <param name="displayName"> The display name for alert rule template. </param>
        /// <param name="requiredDataConnectors"> The required data connectors for this template. </param>
        /// <param name="status"> The alert rule template status. </param>
        /// <param name="severity"> The severity for alerts created by this alert rule. </param>
        /// <param name="tactics"> The tactics of the alert rule template. </param>
        /// <param name="techniques"> The techniques of the alert rule. </param>
        /// <param name="sourceSettings"> All supported source signal configurations consumed in fusion detection. </param>
        internal FusionAlertRuleTemplate(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AlertRuleKind kind, int? alertRulesCreatedByTemplateCount, DateTimeOffset? createdDateUTC, DateTimeOffset? lastUpdatedDateUTC, string description, string displayName, IList<AlertRuleTemplateDataSource> requiredDataConnectors, TemplateStatus? status, AlertSeverity? severity, IList<AttackTactic> tactics, IList<string> techniques, IList<FusionTemplateSourceSetting> sourceSettings) : base(id, name, resourceType, systemData, kind)
        {
            AlertRulesCreatedByTemplateCount = alertRulesCreatedByTemplateCount;
            CreatedDateUTC = createdDateUTC;
            LastUpdatedDateUTC = lastUpdatedDateUTC;
            Description = description;
            DisplayName = displayName;
            RequiredDataConnectors = requiredDataConnectors;
            Status = status;
            Severity = severity;
            Tactics = tactics;
            Techniques = techniques;
            SourceSettings = sourceSettings;
            Kind = kind;
        }

        /// <summary> the number of alert rules that were created by this template. </summary>
        public int? AlertRulesCreatedByTemplateCount { get; set; }
        /// <summary> The time that this alert rule template has been added. </summary>
        public DateTimeOffset? CreatedDateUTC { get; }
        /// <summary> The time that this alert rule template was last updated. </summary>
        public DateTimeOffset? LastUpdatedDateUTC { get; }
        /// <summary> The description of the alert rule template. </summary>
        public string Description { get; set; }
        /// <summary> The display name for alert rule template. </summary>
        public string DisplayName { get; set; }
        /// <summary> The required data connectors for this template. </summary>
        public IList<AlertRuleTemplateDataSource> RequiredDataConnectors { get; }
        /// <summary> The alert rule template status. </summary>
        public TemplateStatus? Status { get; set; }
        /// <summary> The severity for alerts created by this alert rule. </summary>
        public AlertSeverity? Severity { get; set; }
        /// <summary> The tactics of the alert rule template. </summary>
        public IList<AttackTactic> Tactics { get; }
        /// <summary> The techniques of the alert rule. </summary>
        public IList<string> Techniques { get; }
        /// <summary> All supported source signal configurations consumed in fusion detection. </summary>
        public IList<FusionTemplateSourceSetting> SourceSettings { get; }
    }
}
