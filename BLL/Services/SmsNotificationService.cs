﻿using BLL.Interfaces;
using BLL.Models;
using Shared;

namespace BLL.Services
{
    public class SmsNotificationService : GenericService<SMSNotification>, ISmsNotificationService
    {
        public override async Task SendNotification(SMSNotification model)
        {
            var notification = new GenerateNotificationService().GenerateNotifications(model);

            await File.WriteAllTextAsync($"{Directory.GetCurrentDirectory()}\\{Consts.smsNotification}\\{model.Name}.json", notification.ToString());
        }
    }
}
