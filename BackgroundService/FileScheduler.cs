using Quartz;
using Quartz.Impl;

namespace BackgroundService
{
    public class FileScheduler
    {
        public static async void Start()
        {
            IScheduler scheduler = await StdSchedulerFactory.GetDefaultScheduler();
            await scheduler.Start();
            IJobDetail job = JobBuilder.Create<FilesCollector>().Build();

            ITrigger trigger = TriggerBuilder.Create()
                .WithIdentity("getFiles", "group1")
                .StartNow()
                .WithSimpleSchedule(x=> x.WithIntervalInMinutes(2)
                .RepeatForever())
                .Build();
            await scheduler.ScheduleJob(job, trigger);
        }
    }
}