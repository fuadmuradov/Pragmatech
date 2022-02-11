using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessWhat
{
    public partial class Form1 : Form
    {
        public static string[] arrword;
        List<string> wrongexpression = new List<string>();
        string SecondExpression="";
        string firstExpression="";
        int second = 60;
        int min = 1;
        int countexpress = 0;
        int wrongans=0;
        int correctans=0;
        
        int score=0;
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtsentence.Text == "")
            {
                MessageBox.Show("Write a Sentence", "Warning", MessageBoxButtons.OK);
                return;
            }
            timer1.Enabled=true;
            string sentence = txtsentence.Text.ToString().ToLower();
            sentence = sentence.Replace(",", "");
            sentence = sentence.Replace(".", "");
            arrword = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            RandomGenerator();
            countexpress++;



        }

       



        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtsentence.Text == "")
            {
                MessageBox.Show("Write a Sentence", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtsecond.Text == "")
            {
                MessageBox.Show("Write Second Expression", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            counter++;
            string answer = txtsecond.Text;
            if (answer == SecondExpression)
            {
                correctans++;
                if (counter == 1) score += 6;
                if (counter == 2) score += 4;
                if (counter == 3) score += 2;
                RandomGenerator();
                countexpress++;
                counter = 0;

            }
            else
            {
                wrongans++;
                if (counter==3)
                {
                    wrongexpression.Add(SecondExpression);
                    RandomGenerator();
                    countexpress++;
                    counter = 0;
                }
                MessageBox.Show("Wrong Answer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
        }

        Thread th;
        public void openform(object obj)
        {
            Application.Run(new Form2(wrongexpression,countexpress, correctans, wrongans, score));
        }
        private void timer1_Tick(object sender, EventArgs e)
        {


            //send value to Form2
            if(second == 0 && min == 0)
            {
             
              
                timer1.Enabled = false;

                this.Close();
                th = new Thread(openform);
                th.Start();



            }
            
            if (second == 0 && min == 1)
            {
                second = 60;
                min = 0;
            }
     
            lblSecond.Text = second.ToString();
            label1.Text = min.ToString();
           second--;
        }





        private void RandomGenerator()
        {
            Random rd = new Random();
            int num1 = rd.Next(arrword.Length - 2);
            int num2 = rd.Next(arrword.Length - 2);

            firstExpression = Expression(num1);
            label6.Text = firstExpression;

            SecondExpression = Expression(num2);
           
        }




        private static string Expression(int num)
        {
            string express = "";
            if (arrword[num] == "a" || arrword[num] == "of" || arrword[num] == "-")
            {
                express = arrword[num - 1] + " " + arrword[num] + " " + arrword[num + 1];
            }
            else if (arrword[num + 1] == "a" || arrword[num + 1] == "of" || arrword[num + 1] == "-")
            {
                express = arrword[num] + " " + arrword[num + 1] + " " + arrword[num + 2];
            }
            else
            {
                express = arrword[num] + " " + arrword[num + 1];
            }

            return express;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
