﻿using System;
using System.Collections.Generic;
using BLL.Common.Contract;
using BLL.Common.TaskRecovery;

namespace BLL.Common.Sequence
{
    public abstract class Sequence
    {
        protected readonly List<IRunnable> Tasks;
        public RecoveryOptionsDto RecoveryOptions { get; }
        protected readonly Action FailAction;
        public int RunCount { get; }

        protected Sequence(List<IRunnable> tasks, RecoveryOptionsDto recoveryOptions, Action failAction, int runCount)
        {
            Tasks = tasks;
            RecoveryOptions = recoveryOptions;
            FailAction = failAction;
            RunCount = runCount;
        }
    }
}