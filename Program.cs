using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BookstoreClient;
using GraphQL.Client.Abstractions;
using GraphQL.Client.Serializer.Newtonsoft;
using GraphQL.Client.Http;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7043/graphql") });

builder.Services.AddScoped<IGraphQLClient>(sp =>
{
    var options = new GraphQLHttpClientOptions
    {
        EndPoint = new Uri("https://localhost:7043/graphql") // Replace with your GraphQL endpoint
    };
    return new GraphQLHttpClient(options, new NewtonsoftJsonSerializer());
});

await builder.Build().RunAsync();
