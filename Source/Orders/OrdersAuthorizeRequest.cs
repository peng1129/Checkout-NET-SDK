// This class was generated on Tue, 04 Sep 2018 12:18:45 PDT by version 0.1.0-dev+904328-dirty of Braintree SDK Generator
// OrdersAuthorizeRequest.cs
// @version 0.1.0-dev+904328-dirty
// @type request
// @data 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
// DO NOT EDIT
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;


namespace CheckoutNetsdk.Orders
{
    /// <summary>
    /// Authorizes payment for an order. The response shows details of authorizations. You can make this call only if you specified `intent=AUTHORIZE` in the create order call.
    /// </summary>
    public class OrdersAuthorizeRequest : HttpRequest
    {
        public OrdersAuthorizeRequest(string OrderId) : base("/v2/checkout/orders/{order_id}/authorize?", HttpMethod.Post, typeof(Order))
        {
            try {
                this.Path = this.Path.Replace("{order_id}", Uri.EscapeDataString(Convert.ToString(OrderId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        public OrdersAuthorizeRequest PayPalClientMetadataId(string PayPalClientMetadataId) 
        {
            this.Headers.Add("PayPal-Client-Metadata-Id", PayPalClientMetadataId);
            return this;
        }
        
        public OrdersAuthorizeRequest PayPalRequestId(string PayPalRequestId) 
        {
            this.Headers.Add("PayPal-Request-Id", PayPalRequestId);
            return this;
        }
        
        public OrdersAuthorizeRequest Prefer(string Prefer) 
        {
            this.Headers.Add("Prefer", Prefer);
            return this;
        }
        
        
        public OrdersAuthorizeRequest RequestBody(OrderActionRequest OrderActionRequest)
        {
            this.Body = OrderActionRequest;
            return this;
        }
    }
}