﻿using MessageHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlMessages
{
    [MessageClass("RemoveFileMsg")]
    public class RemoveFileMsg
    {
        [MessageField]
        public string FileName { get; set; }
    }
}
