using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    class PharmacyManager : IPharmacy
    {
        public List<Medicine> Medicines { get; set; }
        public int totalincome { get; set; }

        public PharmacyManager()
            {
            this.Medicines = new List<Medicine>();
              }
        public void Add(Medicine medicines)
        {
           bool exist_drug = false;

            foreach (var item in Medicines) { 
                if(item.Drug_Name.ToLower().Trim() == medicines.Drug_Name.ToLower().Trim())
                {
                    exist_drug = true; break;
                }
            }

            if (!exist_drug) 
            {
                Medicines.Add(medicines);
            }
            else
            {
                throw new ThisDrugAlreadyHave("This Drug Already have!!");
            }

        }

        public Medicine FindMedicineByName(string drug_name)
        {
            Medicine searched_drug  ;
            searched_drug = Medicines.Find(x=> x.Drug_Name == drug_name);


            return searched_drug;
        }

        public void Sell(string drug_name, int drug_count)
        {
            // Medicines.Find(x=> x.Drug_Name == drug_name)

            foreach ( var item in Medicines)
            {
                if(item.Drug_Name == drug_name)
                {
                    if(item.Drug_Count >= drug_count) 
                    {
                    item.Drug_Count = item.Drug_Count - drug_count;
                        totalincome = totalincome + item.Drug_Price;
                    }
                    else { throw new NotEnoughDrug("There are not so meny Drug !"); }
                }
                
            }
        }
    }
}
