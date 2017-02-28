using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoseleyPA3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Package Shipping Calculator");

            Console.WriteLine();//intentionally blank

            string packagesInput;
            int packages;

            Console.Write("How many packages would you like to ship?  ");
            Console.ForegroundColor = ConsoleColor.Red;
            packagesInput = Console.ReadLine();
            packages = int.Parse(packagesInput);

            Console.WriteLine(); //intentionally blank

            int counter;
            counter = 1;

            string weightInput;
            double weight;
            double sum;
            sum = 0;

            while (counter > 0 && counter<= packages)

            {
                Console.ForegroundColor = ConsoleColor.Black;
               Console.Write("Please enter the weight of package {0}: ", counter);
                Console.ForegroundColor = ConsoleColor.Red;
                weightInput = Console.ReadLine();
                weight = double.Parse(weightInput);
                sum = sum + weight;
                counter = counter + 1;
            }

            Console.WriteLine();//intentionally blank
           
            double cost;
            cost = sum * 2.35;

            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("The cost to ship {0} packages is {1:C}", packages, cost);
                    

            
            Console.ReadKey();
        }
    }
}
