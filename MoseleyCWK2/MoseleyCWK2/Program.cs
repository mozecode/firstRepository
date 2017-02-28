using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoseleyCWK2
{
    class Program
    {
        static void Main(string[] args)
        {
            string moneyInput;
            double money;
         
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\tValentine's Gift Calculator");

            Console.WriteLine(); //intentionally blank

            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Enter the money you wish to spend:  $");

            Console.ForegroundColor = ConsoleColor.Magenta;
            moneyInput = Console.ReadLine();

            money = double.Parse(moneyInput);

            

            if (money <0.25)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Sleeping on the couch is free.");

            }

           else if(money >= 0.25 && money <3)
            {
                int candies = ((int)(money / 0.25));
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("You should buy {0} chocolate candies.", candies);

            }

           else if (money >=3 && money < 50)

            {

                int roses = ((int)(money / 1.99));
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("You should buy {0} roses.", roses);

            }

           else
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Spa and massage day!");
            }

            Console.ReadKey();

        } //end of calculator
    }
}
