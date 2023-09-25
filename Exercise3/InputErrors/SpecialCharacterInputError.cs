using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.InputErrors
{
    public class SpecialCharacterInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a special character in a text only field. This fired an error!";
        }
    }
}
