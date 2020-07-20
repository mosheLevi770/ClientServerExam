﻿using MessageHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlMessages
{
    [MessageClass("UserValidationStatus")]
    public class UserValidationStatus
    {
        [MessageField]
        public bool Validated { get; set; }
    }
}
