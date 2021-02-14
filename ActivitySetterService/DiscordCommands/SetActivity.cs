// -----------------------------------------------------------------------
// <copyright file="SetActivity.cs" company="TrickyBestia">
// Copyright (c) TrickyBestia. All rights reserved.
// Licensed under the CC BY-ND 4.0 license.
// </copyright>
// -----------------------------------------------------------------------

using System.Threading.Tasks;

using Discord;
using TrickyBot;
using TrickyBot.Services.DiscordCommandService.API.Abstract;
using TrickyBot.Services.DiscordCommandService.API.Features;
using TrickyBot.Services.DiscordCommandService.API.Features.Conditions;

namespace ActivitySetterService.DiscordCommands
{
    internal class SetActivity : ConditionDiscordCommand
    {
        public SetActivity()
        {
            this.Conditions.Add(new DiscordCommandPermissionCondition("activity.set"));
        }

        public override string Name { get; } = "activity set";

        public override DiscordCommandRunMode RunMode { get; } = DiscordCommandRunMode.Sync;

        protected override async Task Execute(IMessage message, string parameter)
        {
            var service = Bot.Instance.ServiceManager.GetService<ActivitySetterService>();
            service.Config.Activity = parameter;
            await service.UpdateStatus();
        }
    }
}