﻿using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using System.Net;
using System.Runtime;

namespace SdetBootcampDay3.Exercises
{
    [TestFixture]
    public class Exercises01
    {
        private const string BASE_URL = "http://jsonplaceholder.typicode.com";

        private RestClient client;

        [OneTimeSetUp]
        public void SetupRestSharpClient()
        {
            client = new RestClient(BASE_URL);
        }

        [Test]
        public async Task GetDataForUser1_CheckStatusCode_ShouldBeHttpOK()
        {
            RestRequest request = new RestRequest("/users/1", Method.Get);

            RestResponse response = await client.ExecuteAsync(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task GetDataForUser1_CheckStatusCode_ShouldBeHttp200()
        {
            RestRequest request = new RestRequest("/users/1", Method.Get);

            RestResponse response = await client.ExecuteAsync(request);

            /**
             * TODO: Assert that the response status code is equal to 200 (integer)
             */

            Assert.That((int)response.StatusCode, Is.EqualTo(200));

        }

        [Test]
        public async Task GetDataForUser2_CheckContentType_ShouldContainApplicationJson()
        {
            /**
             * TODO: Create and execute a new GET request to 'users/2'
             * Verify that the response Content-Type contains 'application/json'
             */

             RestRequest request = new RestRequest("/users/2", Method.Get);

             RestResponse response = await client.ExecuteAsync(request);

             Assert.That(response.ContentType, Does.Contain("application/json"));

        }

        [Test]
        public async Task GetDataForUser3_CheckServerHeader_ShouldBeCloudflare()
        {
            /**
             * TODO: Create and execute a new GET request to '/users/3'
             * Verify that the value of the 'Server' response header is
             * equal to 'cloudflare'
             */

            RestRequest request = new RestRequest("/users/2", Method.Get);

            RestResponse response = await client.ExecuteAsync(request);

            string responseHeader = response.Headers
                                            .Where(x => x.Name.Equals("Server"))
                                            .Select(x => x.Value.ToString())
                                            .First();

            Assert.That(responseHeader, Is.EqualTo("cloudflare"));
        }

        [Test]
        public async Task GetDataForUser4_CheckName_ShouldBePatriciaLebsack()
        {
            /**
             * TODO: Create and execute a new GET request to '/users/4'
             * Verify that the value of the 'name' response body element
             * is equal to 'Patricia Lebsack'
             */

        }

        [Test]
        public async Task GetDataForUser5_CheckCompanyName_ShouldBeKeeblerLLC()
        {
            /**
             * TODO: Create and execute a new GET request to '/users/5'
             * Verify that the value of the company name in the response body
             * is equal to 'Keebler LLC'
             */

        }
    }
}
