using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowDemo1
{
    static class Program
    {

        


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());





            /*Deck deck1 = new Deck();
            //deck1.Shuffle();
            /* for(int i=0;i<52;i++)
             {
                 Console.Write("{0,-19}", deck1.DealCard());
                 if ((i + 1) % 4 == 0)
                 {
                     Console.WriteLine();
                 } 
             }*/
           /* Card c1 = new Card("5", "H");
            Card c2 = new Card("4", "C");
            Card c3 = new Card("3", "S");
            Card c4 = new Card("6", "D");
            Card c5 = new Card("4", "C");
            Card c6 = new Card("2", "D");
            Card c7 = new Card("9", "H");
            Card c8 = new Card("2", "S");
            Card c9 = new Card("4", "S");
            Card c0 = new Card("3", "C");
            Card c10 = new Card("6", "C");
            Card c20 = new Card("3", "C");
            Card c30 = new Card("5", "C");
            Card c40 = new Card("6", "C");
            Queue pomoc = new Queue();
            Queue spil1 = new Queue();
            Queue spil2 = new Queue();

            spil1.Enqueue(c1);
            spil1.Enqueue(c2);
            spil1.Enqueue(c3);
            spil1.Enqueue(c4);
            spil1.Enqueue(c5);
            spil1.Enqueue(c6);
            spil1.Enqueue(c7);

            spil2.Enqueue(c8);
            spil2.Enqueue(c9);
            spil2.Enqueue(c0);
            spil2.Enqueue(c10);
            spil2.Enqueue(c20);
            spil2.Enqueue(c30);
            spil2.Enqueue(c40);


            /* String s1 = "";
             for (int i = 0; i < 14; i++)
             {
                 if (i % 2 == 0)
                 {
                     s1 = Console.ReadLine();
                     spil1.Enqueue(Int32.Parse(s1));
                 }
                 else
                 {
                     s1 = Console.ReadLine();
                     spil2.Enqueue(Int32.Parse(s1));
                 }
             }*/
           /* int brk = 0;
            while (brk < 100000 && spil1.Count != 0 && spil2.Count != 0)
            {
                RatR(spil1, spil2, pomoc);
                brk++;
            }*/

            /*if (spil1.Count == 0)
                Console.WriteLine("Pobjednik je drugi igrac u " + brk + " koraka");
            else if (spil2.Count == 0)
                Console.WriteLine("Pobjednik je prvi igrac u " + brk + " koraka");
            else
                Console.WriteLine("Nerijeseno");
            Console.WriteLine("Prvi igrac:");
            foreach (object i in spil1)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
            Console.WriteLine("Drugi igrac:");
            foreach (object i in spil2)
            {
                Console.Write(" " + i);
            }*/




        }
    }
}
