using Blazorade.Msal.Configuration;
using GraphClientSample;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services
    .AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) })
    .AddBlazoradeMsal((sp, options) =>
    {
        var config = sp.GetRequiredService<IConfiguration>();
        var appSection = config.GetSection("app");
        appSection.Bind(options);

        options.InteractiveLoginMode = InteractiveLoginMode.Popup;
        options.TokenCacheScope = TokenCacheScope.Persistent;
        options.PostLogoutUrl = "/loggedout";
    })
    ;

await builder.Build().RunAsync();
