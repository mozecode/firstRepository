using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoseleyHMK2
{
    class Program
    {
        static void Main(string[] args)
        {

            string lengthInput, widthInput;
            int length, width, perimeter;
            double totalCost;

            Console.WriteLine("\tWelcome to the Frame Ordering Application!");
            Console.Write("Please enter a frame width:  ");

            widthInput = Console.ReadLine();
            width = int.Parse(widthInput);

            Console.Write("Please enter a frame length:  ");

            lengthInput = Console.ReadLine();

            length = int.Parse(lengthInput);

            perimeter = 2 * length + 2 * width;

            if (perimeter <=24)

            { totalCost = perimeter * 1.24; }

            else if (perimeter >24 && perimeter<=48)

            { totalCost = perimeter * 0.99; }

            else

            { totalCost = perimeter * 0.78; }

            Console.WriteLine("The frame perimeter is {0} and the cost is {1:C}", perimeter, totalCost);

            Console.ReadKey();
        }
    }
}
