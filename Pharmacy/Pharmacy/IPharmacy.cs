using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    interface IPharmacy
    {
        public List<Medicine> Medicines { get; set; }
        public void Sell(string drug_name, int drug_count);
        public Medicine FindMedicineByName(string drug_name);
        public void Add(Medicine medicines);
        public int totalincome { get; set; }
    }

}
