﻿using LibHac.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HACGUI.Main.TaskManager.Tasks
{
    public class ResizeTask : ProgressTask
    {
        private readonly IFile Target;
        private readonly long Length;

        public ResizeTask(string title, IFile target, long length) : base(title)
        {
            Target = target;
            Length = length;
        }

        public override Task CreateTask()
        {
            return new Task(() => 
            {
                Target.SetSize(Length);
            });
        }
    }
}
