using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualCard
{
    class Virtualcard
    {

        public static int k = 1;

        public int id { get; set; }
        public string number { get; set; }
        public int amount { get; set; }
        public string activeTime { get; set; }
        public int RealcardID { get; set; }




        public Virtualcard(int day, int _amount, int rcard)
        {
            this.id = k++;
            this.number = Randomgenerete();
            amount = _amount;
            activeTime = DateTime.Now.AddDays(day).ToString("dd/MM/yyyy");
            this.RealcardID = rcard;
        }


        public string Randomgenerete()
        {
            string num = "";
            Random random = new Random();
            num += random.Next(10000, 99999).ToString();
            num += random.Next(10000, 99999).ToString();
            num += random.Next(100000, 999999).ToString();
            return num;
        }

    }
}
