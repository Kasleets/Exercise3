﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.InputErrors
{
    public class EmptyInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use an empty input. This fired an error!";
        }
    }
}
