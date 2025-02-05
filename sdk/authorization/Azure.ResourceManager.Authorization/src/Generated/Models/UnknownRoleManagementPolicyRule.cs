// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> The UnknownRoleManagementPolicyRule. </summary>
    internal partial class UnknownRoleManagementPolicyRule : RoleManagementPolicyRule
    {
        /// <summary> Initializes a new instance of <see cref="UnknownRoleManagementPolicyRule"/>. </summary>
        /// <param name="id"> The id of the rule. </param>
        /// <param name="ruleType"> The type of rule. </param>
        /// <param name="target"> The target of the current rule. </param>
        internal UnknownRoleManagementPolicyRule(string id, RoleManagementPolicyRuleType ruleType, RoleManagementPolicyRuleTarget target) : base(id, ruleType, target)
        {
            RuleType = ruleType;
        }
    }
}
