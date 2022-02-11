using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualCard
{
    class RealCard
    {
        private static int counter = 1;
        public int id { get; set; }
        public string number { get; set; }
        public int amount { get; set; }
        public string date { get; set; }
        public int vcount = 0;
       // EndDate = DateTime.Parse(DateTime.Now.AddDays(+dday).ToString("yyy-MM-dd")),
        public RealCard(string number, int amount, string date)
        {
            this.id = counter;
            this.number = number;
            this.amount = amount;
            this.date = date;
            counter++;
        }
    }
}
