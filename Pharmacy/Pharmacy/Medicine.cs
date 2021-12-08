using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    class Medicine
    {
        public string Drug_Name;
        public int Drug_Price;
        public int Drug_Count;

        public Medicine(string name, int price, int count)
        {
            this.Drug_Name = name;
            this.Drug_Price = price;
            this.Drug_Count = count;
        }

        //public int Price {
        //    get
        //    {
        //        return Drug_Price;
        //    }

        //    set
        //    {
        //        if(Convert.ToInt32(value) >= 0)
        //        Drug_Price = value;
                
        //    }
        
        //}

        //public int Count
        //{
        //    get
        //    {
        //        return Drug_Count;
        //    }

        //    set
        //    {
        //        if (Convert.ToInt32(value) >= 0)
        //            Drug_Count = value;

        //    }

        //}


    }
}
