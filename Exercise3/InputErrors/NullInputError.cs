using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.InputErrors
{
    public class NullInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a null input. This fired an error!";
        }
    }
}
