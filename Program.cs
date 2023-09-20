using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.WebSockets;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddHttpClient();
builder.Services.AddServerSideBlazor()
    .AddHubOptions(o => {
        o.ClientTimeoutInterval = TimeSpan.FromMinutes(30);
        o.HandshakeTimeout = TimeSpan.FromMinutes(30);
        });

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.UseWebSockets();

app.Run();
