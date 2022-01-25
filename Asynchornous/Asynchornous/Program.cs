using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Asynchornous
{
    class Program
    {
        static void Main(string[] args)
        {

            // Calculate();

            //Method1();
            //Method2();

            // Calculate1_2();

            Test2();

            Console.Read();
        }



        // method1()  ve method2() eyni anda cagirilir  

       //public static async Task Method1()
       // {
       //    await Task.Run(() =>
       //     {
       //         for(int i=0; i<100; i++)
       //         {
       //             Console.WriteLine($" Method 1 i-{i}");
       //             Task.Delay(100).Wait();
       //         }
       //     });



       // }


       // public static void Method2()
       // {
       //     for (int i = 0; i <50; i++)
       //     {
       //         Console.WriteLine($" Method 2 i-{i}");
       //         Task.Delay(100).Wait();
       //     }
       // }

        public static void Calculate()
        {
            /* Task.Run funksiyasisinin daxilinde yeni body yaradib
             * Calculate1() methodunu cagirilir
             * sonra bu methoddan gelen deyer task1 e meimsedilir 
             * task1.getawaiter() funksiyasi calculate1 methodunun bitmesini gozleyir
             * awaiter.onComplated() calculate1 memthodu bitdikden sonra daxilindeki emeliyyatlari icara eliyir
             * 
             */

            //var task1 = Task.Run(()=> {
            //   return Calculate1();
            //});
            //var awaiter = task1.GetAwaiter();

         


            //awaiter.OnCompleted(() =>
            //{
            //    Calculate2();
            //});

           
           // Calculate2();
           // Calculate3();

        }

        static async void Test2()
        {
            await Test1();
        }
      
        static async Task Test1()
        {
            await Calculate1_2();
        } 
        public static async Task Calculate1_2()
        {
            await Task.Run(() =>
            {
                for(int i=0; i<20; i++)
                {
                    Console.WriteLine($"wait {i}");
                    Task.Delay(100).Wait();
                } 
            });


            Calculate2();
            Calculate3();
        }

        public static int Calculate1()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Running Calculate1");
            return 100;
        }

        static int Calculate2()
        {
            Thread.Sleep(2000);
            Console.WriteLine($"Running Calculate2");
            return 200;
        }

        static int Calculate3()
        {

            Console.WriteLine("Running Calculate3");
            return 300;
        }



    }
}
