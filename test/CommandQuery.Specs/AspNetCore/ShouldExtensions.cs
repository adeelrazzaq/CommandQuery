﻿using CommandQuery.AspNetCore.Internal;
using Machine.Specifications;
using Microsoft.AspNetCore.Mvc;

namespace CommandQuery.Specs.AspNetCore
{
    public static class ShouldExtensions
    {
        public static void ShouldBeError(this ObjectResult result, string message)
        {
            result.ShouldNotBeNull();
            var value = result.Value as Error;
            value.ShouldNotBeNull();
            value.Message.ShouldEqual(message);
        }
    }
}