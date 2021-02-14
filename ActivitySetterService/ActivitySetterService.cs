// -----------------------------------------------------------------------
// <copyright file="ActivitySetterService.cs" company="TrickyBestia">
// Copyright (c) TrickyBestia. All rights reserved.
// Licensed under the CC BY-ND 4.0 license.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Threading.Tasks;

using TrickyBot.API.Abstract;
using TrickyBot.API.Features;

namespace ActivitySetterService
{
    public class ActivitySetterService : ServiceBase<ActivitySetterServiceConfig>
    {
        public override ServiceInfo Info { get; } = new ServiceInfo()
        {
            Author = "TrickyBestia",
            Name = "ActivitySetterService",
            Version = new Version(1, 0, 0, 0),
            GithubRepositoryUrl = "https://github.com/TrickyBestia/ActivitySetterService",
        };

        internal async Task UpdateStatus()
        {
            await TrickyBot.Bot.Instance.Client.SetGameAsync(this.Config.Activity);
        }

        protected override Task OnStart() => this.UpdateStatus();

        protected override Task OnStop() => Task.CompletedTask;
    }
}