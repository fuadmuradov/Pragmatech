using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy2.Exceptions
{
    class DrugAlreadyExist:Exception
    {
        private string message;
        public DrugAlreadyExist(string message)
        {
            this.message = message;
        }

        public override string Message => message;

    }
}
