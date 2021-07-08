// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using static Microsoft.AspNetCore.Http.Results;

var app = WebApplication.Create(args);

app.MapGet("/", () => "Hello World");

app.MapGet("/json", () => Json(new Person("John", 42)));

app.MapGet("/ok-object", () => Ok(new Person("John", 42)));

app.MapGet("/accepted-object", () => Accepted("/ok-object", new Person("John", 42)));

app.MapGet("/many-results", (int id) =>
{
    if (id == -1)
    {
        return NotFound();
    }

    return RedirectPermanent("/json");
});

app.MapGet("/environment", (IHostEnvironment environment) => environment.EnvironmentName);

app.MapGet("/greeting", (IConfiguration config) => config["Greeting"]);

app.Run();

record Person(string Name, int Age);
