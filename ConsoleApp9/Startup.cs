using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;
using BackgroundService;
using BLL.Interfaces;
using BLL.Services;

namespace ConsoleApp9
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ISeparateNotification, SeparateNotificationService>();
            services.AddSingleton<IEmailNotificatioNService, EmailNotificationservice>();
            services.AddSingleton<IPdfNotificationService, PdfNotificationService>();
            services.AddSingleton<ISmsNotificationService, SmsNotificationService>();
            services.AddTransient<JobFactory>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHost env)
        {

        }
    }
}
