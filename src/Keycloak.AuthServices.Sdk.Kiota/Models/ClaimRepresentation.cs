// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Keycloak.AuthServices.Sdk.Kiota.Admin.Models {
    public class ClaimRepresentation : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The address property</summary>
        public bool? Address { get; set; }
        /// <summary>The email property</summary>
        public bool? Email { get; set; }
        /// <summary>The gender property</summary>
        public bool? Gender { get; set; }
        /// <summary>The locale property</summary>
        public bool? Locale { get; set; }
        /// <summary>The name property</summary>
        public bool? Name { get; set; }
        /// <summary>The phone property</summary>
        public bool? Phone { get; set; }
        /// <summary>The picture property</summary>
        public bool? Picture { get; set; }
        /// <summary>The profile property</summary>
        public bool? Profile { get; set; }
        /// <summary>The username property</summary>
        public bool? Username { get; set; }
        /// <summary>The website property</summary>
        public bool? Website { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="ClaimRepresentation"/> and sets the default values.
        /// </summary>
        public ClaimRepresentation() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ClaimRepresentation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ClaimRepresentation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ClaimRepresentation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"address", n => { Address = n.GetBoolValue(); } },
                {"email", n => { Email = n.GetBoolValue(); } },
                {"gender", n => { Gender = n.GetBoolValue(); } },
                {"locale", n => { Locale = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetBoolValue(); } },
                {"phone", n => { Phone = n.GetBoolValue(); } },
                {"picture", n => { Picture = n.GetBoolValue(); } },
                {"profile", n => { Profile = n.GetBoolValue(); } },
                {"username", n => { Username = n.GetBoolValue(); } },
                {"website", n => { Website = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("address", Address);
            writer.WriteBoolValue("email", Email);
            writer.WriteBoolValue("gender", Gender);
            writer.WriteBoolValue("locale", Locale);
            writer.WriteBoolValue("name", Name);
            writer.WriteBoolValue("phone", Phone);
            writer.WriteBoolValue("picture", Picture);
            writer.WriteBoolValue("profile", Profile);
            writer.WriteBoolValue("username", Username);
            writer.WriteBoolValue("website", Website);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}