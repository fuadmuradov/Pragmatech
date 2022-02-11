using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualCard
{
     class Manager:Form
    {
        public static List<RealCard> rcard = new List<RealCard>();
        public static List<Virtualcard> vcard = new List<Virtualcard>();
        public Manager()
        {
          
          
        }

        public static void CreateRealCard(string number, int amount, string date)
        {
            RealCard realCard = rcard.FirstOrDefault(x => x.number == number);
            if (realCard==null)
            {
                RealCard card = new RealCard(number, amount, date);
                rcard.Add(card);
            }
            
        }

        public static void CreateVirtualCard(string rnumber, int amount, int day)
        {
            RealCard card = rcard.Find(x => x.number == rnumber);

            if(card != null)
            {
                card.amount = card.amount - amount;
                card.vcount++;
                Virtualcard virtualcard = new Virtualcard(day, amount, card.id);
                vcard.Add(virtualcard);
                
            }
            
        }

        public static bool CheckRealCard(string num,int amount, int day)
        {
            RealCard realcard = rcard.FirstOrDefault(x => x.number == num);
            if(realcard==null)
            {
                MessageBox.Show("Real Card not Exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
               
            }
            if(realcard.vcount>5)
            {
                MessageBox.Show("you cannot create more than 5 cards", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            if (Convert.ToDateTime(realcard.date) < DateTime.Now.AddDays(day))
            {
                MessageBox.Show("Reduce Day", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (realcard.amount < amount)
            {
                MessageBox.Show("this amount not exist your card", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            return true;
        }

        public static bool SearchRealCard(string num)
        {
            if(rcard.Any(x => x.number == num))
            {
                return true;
            }

            return false;
        }

        public static List<string> VirtualCardList(string num)
        {
            List<string> Vlist = new List<string>();
             RealCard realCard = rcard.FirstOrDefault(x => x.number == num);

            if(realCard != null)
            {
                foreach(var item in vcard)
                {
                    if(item.RealcardID==realCard.id)
                    {
                        Vlist.Add(item.number);
                    }
                }
            }

            return Vlist;
        }


        public static void DeleteVirtualCard(string number)
        {
            Virtualcard virtualCard = vcard.FirstOrDefault(x => x.number == number);
            if(virtualCard != null)
            {
                // rcard.Where(x=>x.id==virtualCard.RealcardID)
                foreach (var item in rcard)
                {
                    if (item.id == virtualCard.RealcardID)
                    {
                        item.amount += virtualCard.amount;
                    }
                }

                vcard.Remove(virtualCard);
            }
        }
    }
}
