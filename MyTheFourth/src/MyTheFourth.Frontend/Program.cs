using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyTheFourth.Frontend.Extensions;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.AddDefaultConfiguration();

await builder.Build().RunAsync();