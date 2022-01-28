using Pharmacy2.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy2
{
    class pManager : Ipharmacy
    {
        public List<Medicine> Medicines { get; set; }
        public int totalincome { get; set; }

        public pManager()
        {
            Medicines = new List<Medicine>();
            totalincome = 0;
        }
        public void Add(Medicine medicine)
        {
            bool checker = Medicines.Any(x => x.Name.Trim().ToLower() == medicine.Name.Trim().ToLower());
            if (!checker)
            {
                Medicines.Add(medicine);
            }
            else
            {
                throw new DrugAlreadyExist("This Drug Already Exist");
            }

        }

        public Medicine FindbyName(string drugname)
        {
           Medicine medicine =  Medicines.FirstOrDefault(x => x.Name.Trim().ToLower() == drugname.Trim().ToLower());

            if (medicine == null)
            {
                throw new DrugAlreadyNotExist("Drug Already Not Exist!");

            }
            else { return medicine; } 
        }

        public void Sell(string drugname , int count)
        {
            Medicine medicine = Medicines.FirstOrDefault(x => x.Name.Trim().ToLower() == drugname.Trim().ToLower());
           
            if(medicine != null)
            {
             if (count < medicine.Counter)
            {
                    totalincome += medicine.Pricer;
                medicine.Counter -= count;
                    //totalincome += double.Parse(medicine.Counter.ToString());
            }
            else
            {
                throw new DrugAlreadyNotExist("Drug not Exist This Amount");
            }
            }
            
           
        }
    }
}
