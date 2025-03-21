// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Text
{
    /// <summary>
    /// The long running task to be performed by the service on the input documents.
    /// Please note <see cref="AnalyzeTextOperationAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AbstractiveSummarizationOperationAction"/>, <see cref="CustomEntitiesOperationAction"/>, <see cref="CustomMultiLabelClassificationOperationAction"/>, <see cref="CustomSingleLabelClassificationOperationAction"/>, <see cref="EntityLinkingOperationAction"/>, <see cref="EntitiesOperationAction"/>, <see cref="ExtractiveSummarizationOperationAction"/>, <see cref="HealthcareOperationAction"/>, <see cref="KeyPhraseOperationAction"/>, <see cref="PiiOperationAction"/> and <see cref="SentimentAnalysisOperationAction"/>.
    /// </summary>
    public abstract partial class AnalyzeTextOperationAction
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AnalyzeTextOperationAction"/>. </summary>
        protected AnalyzeTextOperationAction()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzeTextOperationAction"/>. </summary>
        /// <param name="name"> task name. </param>
        /// <param name="kind"> The kind of task to perform. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AnalyzeTextOperationAction(string name, AnalyzeTextOperationActionKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> task name. </summary>
        public string Name { get; set; }
        /// <summary> The kind of task to perform. </summary>
        internal AnalyzeTextOperationActionKind Kind { get; set; }
    }
}
