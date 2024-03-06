using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using LearningPortal;
using LearningPortal.LearningApp;
using IgniteUI.Blazor.Controls;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddHttpClient();


builder.Services.AddScoped<ILearningAppService, LearningAppService>();
RegisterIgniteUI(builder.Services);

void RegisterIgniteUI(IServiceCollection services)
{
    services.AddIgniteUIBlazor(
        typeof(IgbIconButtonModule),
        typeof(IgbRippleModule),
        typeof(IgbCardModule),
        typeof(IgbButtonModule),
        typeof(IgbListModule),
        typeof(IgbAvatarModule),
        typeof(IgbRatingModule),
        typeof(IgbChipModule),
        typeof(IgbCheckboxModule),
        typeof(IgbAccordionModule),
        typeof(IgbExpansionPanelModule)
    );
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
