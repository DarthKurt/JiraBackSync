﻿using System;

namespace Jira.BackSync.Service.Configuration
{
    internal sealed class TimeUtilsOptions
    {
        public int WorkingWeekOffset { get; set; }

        public TimeSpan DebugOffset { get; set; }
    }
}