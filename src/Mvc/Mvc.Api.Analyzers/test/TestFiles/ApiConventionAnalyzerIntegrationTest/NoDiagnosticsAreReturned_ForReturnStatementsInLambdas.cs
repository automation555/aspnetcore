﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.Mvc;

[assembly: ApiConventionType(typeof(DefaultApiConventions))]

namespace Microsoft.AspNetCore.Mvc.Api.Analyzers
{
    [ApiController]
    public class NoDiagnosticsAreReturned_ForReturnStatementsInLambdas : ControllerBase
    {
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(typeof(string), 404)]
        public IActionResult Put(int id, object model)
        {
            Func<IActionResult> someLambda = () =>
            {
                if (id < -1)
                {
                    // We should not process this.
                    return UnprocessableEntity();
                }

                return null;
            };


            if (id == 0)
            {
                return NotFound();
            }


            if (id == 1)
            {
                return someLambda();
            }

            return Ok();
        }
    }
}
