// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Requested access to shared file/folder.</para>
    /// </summary>
    public class SharedContentRequestAccessDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharedContentRequestAccessDetails> Encoder = new SharedContentRequestAccessDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharedContentRequestAccessDetails> Decoder = new SharedContentRequestAccessDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="SharedContentRequestAccessDetails" /> class.</para>
        /// </summary>
        /// <param name="sharedContentLink">Shared content link.</param>
        public SharedContentRequestAccessDetails(string sharedContentLink = null)
        {
            this.SharedContentLink = sharedContentLink;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="SharedContentRequestAccessDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SharedContentRequestAccessDetails()
        {
        }

        /// <summary>
        /// <para>Shared content link.</para>
        /// </summary>
        public string SharedContentLink { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SharedContentRequestAccessDetails" />.</para>
        /// </summary>
        private class SharedContentRequestAccessDetailsEncoder : enc.StructEncoder<SharedContentRequestAccessDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharedContentRequestAccessDetails value, enc.IJsonWriter writer)
            {
                if (value.SharedContentLink != null)
                {
                    WriteProperty("shared_content_link", value.SharedContentLink, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SharedContentRequestAccessDetails" />.</para>
        /// </summary>
        private class SharedContentRequestAccessDetailsDecoder : enc.StructDecoder<SharedContentRequestAccessDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="SharedContentRequestAccessDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharedContentRequestAccessDetails Create()
            {
                return new SharedContentRequestAccessDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SharedContentRequestAccessDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "shared_content_link":
                        value.SharedContentLink = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
