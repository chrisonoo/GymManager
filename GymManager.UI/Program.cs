using AspNetCore.ReCaptcha;

using GymManager.Application;
using GymManager.Application.Common.Interfaces;
using GymManager.Infrastructure;
using GymManager.UI.Extensions;
using GymManager.UI.Middlewares;

using NLog.Web;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.SetMinimumLevel(LogLevel.Information);
builder.Logging.AddNLogWeb();

builder.Services.AddCulture();

builder.Services.AddReCaptcha(builder.Configuration.GetSection("ReCaptcha"));

builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.DefineViewLocation(builder.Configuration);

builder.Services.AddControllersWithViews();

var app = builder.Build();

using(var scope = app.Services.CreateScope())
{
    app.UseInfrastructure(
        scope.ServiceProvider.GetRequiredService<IApplicationDbContext>(),
        app.Services.GetService<IAppSettingsService>(),
        app.Services.GetService<IEmail>());
}

if(!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseMiddleware<ExceptionHandlerMiddleware>();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
