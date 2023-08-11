using CurrieTechnologies.Razor.SweetAlert2;
using DND.Web;
using DND.Web.Repositories;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7223/") });
builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddSweetAlert2(options => {
    options.Theme = SweetAlertTheme.Dark;
});


await builder.Build().RunAsync();
