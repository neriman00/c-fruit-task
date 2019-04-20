using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_fruit
{
    class Program
    {
        static void Main(string[] args)
        {

            fruit banan = new fruit();
            banan.name = "banan";
            banan.price = 5;
            fruit kivi = new fruit();
            kivi.name = "kivi";
            kivi.price = 4;
            Console.WriteLine("Bu meyvelerimiz var.{0} ve {1}", banan.name, kivi.name);
            Console.WriteLine("meyveleri secin");
            string input = Console.ReadLine();
            Console.Write("Pulunuzu daxil edin :");

            if (input == "banan")
            {


                string money = Console.ReadLine();
                int newMoney = Convert.ToInt32(money);

                if (banan.price < newMoney)
                {
                    Console.WriteLine("kasibsan");
                }
                else
                {
                    Console.WriteLine("Siz banan ala bilersiniz. Meslehetli afrika kivimiz var istemirsiz?");
                }
            }
             if (input == "kivi")
            {
                string money = Console.ReadLine();
                int newMoney = Convert.ToInt32(money);
                if (kivi.price > newMoney)
                {
                    Console.WriteLine("islemiyen dislemez");
                }
                else
                {
                    Console.WriteLine("Siz kivi ala bilersiniz.Meslehetli mozambik bananimiz var istemirsiz?");
                }
            }
        }
    }
}
