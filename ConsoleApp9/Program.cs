using BackgroundService;
using BLL.Interfaces;
using BLL.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Quartz;

IConfiguration config = new ConfigurationBuilder()
    .Build();

var serviceProvider = new ServiceCollection()
    .AddSingleton<ISeparateNotification, SeparateNotificationService>()
    .AddSingleton<IEmailNotificatioNService, EmailNotificationservice>()
    .AddSingleton<IPdfNotificationService, PdfNotificationService>()
    .AddSingleton<ISmsNotificationService, SmsNotificationService>()
    .AddSingleton<IFilesCollector, FilesCollector>()
    .AddQuartz(q =>
    {
        q.UseMicrosoftDependencyInjectionJobFactory();
        q.AddJobAndTrigger<FilesCollector>(config);
    })
.BuildServiceProvider();

serviceProvider.GetService<IFilesCollector>().Start();
while (true)
{

}
