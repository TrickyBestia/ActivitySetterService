// -----------------------------------------------------------------------
// <copyright file="ActivitySetterServiceConfig.cs" company="TrickyBestia">
// Copyright (c) TrickyBestia. All rights reserved.
// Licensed under the CC BY-ND 4.0 license.
// </copyright>
// -----------------------------------------------------------------------

using TrickyBot.API.Interfaces;

namespace ActivitySetterService
{
    public class ActivitySetterServiceConfig : IConfig
    {
        public bool IsEnabled { get; set; } = false;

        public string Activity { get; set; } = string.Empty;
    }
}