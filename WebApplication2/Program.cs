using BackgroundService;
using BLL.Interfaces;
using BLL.Services;
using Quartz;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddTransient<ISeparateNotification, SeparateNotificationService>();
builder.Services.AddTransient<IEmailNotificatioNService, EmailNotificationservice>();
builder.Services.AddTransient<IPdfNotificationService, PdfNotificationService>();
builder.Services.AddTransient<ISmsNotificationService, SmsNotificationService>();
builder.Services.AddTransient<JobFactory>();
builder.Services.AddScoped<DataJob>();
builder.Services.AddScoped<IFilesCollector, FilesCollector>();

builder.Services.AddQuartz(q =>
{
    q.UseMicrosoftDependencyInjectionJobFactory();
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var serviceProvider = scope.ServiceProvider;
    try
    {
        DataScheduler.Start(serviceProvider);
    }
    catch (Exception)
    {
        throw;
    }
}

app.MapGet("/", () => "Hello World!");

app.Run();
