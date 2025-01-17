﻿using System.Net;
using System.Net.Http;
using Xunit;

namespace TennisBookings.Web.IntegrationTests.Extensions
{
    public static class HttpResponseMessageExtensions
    {
        public static void AssertOk(this HttpResponseMessage response)
        {
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}

