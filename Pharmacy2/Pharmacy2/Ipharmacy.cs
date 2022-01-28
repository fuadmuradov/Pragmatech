using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy2
{
   interface Ipharmacy
    {
        public List<Medicine> Medicines { get; set; }
        public int totalincome { get; set; }
        public void Sell(string drugname, int count);

        public void Add(Medicine medicine);
        public Medicine FindbyName(string drugname);


        
    }
}
