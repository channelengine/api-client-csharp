/* 
 * ChannelEngine API V2
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2.3.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using ChannelEngine.Api.Client.Client;
using ChannelEngine.Api.Client.Api;
using ChannelEngine.Api.Client.Model;

namespace ChannelEngine.Api.Client.Test
{
    /// <summary>
    ///  Class for testing OrderApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class OrderApiTests
    {
        private OrderApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OrderApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OrderApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OrderApi
            //Assert.IsInstanceOfType(typeof(OrderApi), instance, "instance is a OrderApi");
        }

        
        /// <summary>
        /// Test OrderAcknowledge
        /// </summary>
        [Test]
        public void OrderAcknowledgeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OrderAcknowledgement model = null;
            //var response = instance.OrderAcknowledge(model);
            //Assert.IsInstanceOf<ApiResponse> (response, "response is ApiResponse");
        }
        
        /// <summary>
        /// Test OrderCreate
        /// </summary>
        [Test]
        public void OrderCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ChannelOrderRequest model = null;
            //var response = instance.OrderCreate(model);
            //Assert.IsInstanceOf<ApiResponse> (response, "response is ApiResponse");
        }
        
        /// <summary>
        /// Test OrderGetNew
        /// </summary>
        [Test]
        public void OrderGetNewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.OrderGetNew();
            //Assert.IsInstanceOf<CollectionOfMerchantOrderResponse> (response, "response is CollectionOfMerchantOrderResponse");
        }
        
        /// <summary>
        /// Test OrderInvoice
        /// </summary>
        [Test]
        public void OrderInvoiceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string merchantOrderNo = null;
            //bool? useCustomerCulture = null;
            //var response = instance.OrderInvoice(merchantOrderNo, useCustomerCulture);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test OrderPackingSlip
        /// </summary>
        [Test]
        public void OrderPackingSlipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string merchantOrderNo = null;
            //bool? useCustomerCulture = null;
            //var response = instance.OrderPackingSlip(merchantOrderNo, useCustomerCulture);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
    }

}
