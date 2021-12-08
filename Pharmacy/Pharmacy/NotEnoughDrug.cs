using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    class NotEnoughDrug:Exception
    {
        private string message;
        public NotEnoughDrug(string message)
        {
            this.message = message;
        }

        public override string Message => message;
    }
}
