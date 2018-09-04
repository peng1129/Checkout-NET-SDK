// This class was generated on Tue, 04 Sep 2018 11:48:14 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// DisplayableMerchantInformation.cs
// @version 0.1.0-dev+904328-dirty
// @type object
// @data H4sIAAAAAAAC/9yVz0/rRhDH7/0rRj6BZByghENORQGpVdUUUdoLRdF4PbFXrGfN7pjgVvzv1doOiZPQ0qqP9/QukXZ+eGY/893Jn9FtU1E0iS61rww2mBqCn8ipAlngB15YV6Joy1Ec/YZOB/8My5ARxdGP1KwPl+SV01UbPIluC4Jy9R29/k4CQ48HNN7CA9slA3qQgqDChiiBi6oidB7EtlZVe7ElOdAMqiD1YGuJQRyyRxU+7WOgErUBR4p0JT4G5GwzAgrtxbomieLowjlsussfx9ENYfYzmyaaLNB4CobHWjvKXg3XzlbkRJOPJnev2Lw4zfkunNQhZ3MOh01MA/MusOAAu2ivu0L0Tg4VNiWxfB4eXBvzEv8zlNprJu/nbVtDMNuuXTiahRy3IkKj/6Csvx1mmSPvk9/r4+NvVWqsenisrVB77n6VF2c57ywzKzTpzKNNO/xaBcTnZ6AKdKiEnAd0BGiMXVIGKS1sOHIGp+PxW1G4EHLtoLoaymZ9K9/1RdcW8DrnBL63S3oiF7dZOTE5NKYBVIoqoQxKfNZlXYIhzqWAhXWAPLx9eEin483Wu4dWoQRq8EROLzSF94USsmtuIWXv7RLoWXtZUR5tY/5/BXRdWKa/0U/V+/foZ+Xa1U/rAa7LNKDWDFo8KGTLWqEZygvurpKT87M+WnMOlUGGbovdHxQilZ+MRsvlMtFSJ5pl5EiNbo9urqZHbeqI+PDTrxllaxbXzMOwBjy2HLs0+gBQaEy4XwiEg+n08IPQQNdEmWqmbKXsfvVNp92iajdiX7UrB2XtBdgKpAS5I+zeGjKcjCHTuZZe99t5yrIP+g0lcO3NyIvuTj2B2eX0sK3u6zQwC8n9Nw5+mf27kYqr/9uipGch9tryvCs9GO0e5+54X4P65j9ow6/A7ut717fvD3Awti9Ai2++k69aovcv9y/f/AUAAP//
// DO NOT EDIT
using System.Runtime.Serialization;
using System.Collections.Generic;


namespace CheckoutNetsdk.Orders
{
    /// <summary>
    /// The merchant information. The merchant is also known as the payee. Appears to the customer in checkout, transactions, email receipts, and transaction history.
    /// </summary>
    [DataContract]
    public class DisplayableMerchantInformation
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public DisplayableMerchantInformation() {}

        /// <summary>
        /// The name of the merchant. Appears to the customer in checkout, payment transactions, email receipts, and transaction history.
        /// </summary>
        [DataMember(Name="brand_name", EmitDefaultValue = false)]
        public string BrandName;

        /// <summary>
        /// The internationalized email address.<blockquote><strong>Note:</strong> Up to 64 characters are allowed before and 255 characters are allowed after the <code>@</code> sign. However, the generally accepted maximum length for an email address is 254 characters. The pattern verifies that an unquoted <code>@</code> sign exists.</blockquote>
        /// </summary>
        [DataMember(Name="business_email", EmitDefaultValue = false)]
        public string BusinessEmail;

        /// <summary>
        /// The phone number, in its canonical international [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164/en).
        /// </summary>
        [DataMember(Name="business_phone", EmitDefaultValue = false)]
        public Phone BusinessPhone;
    }
}

