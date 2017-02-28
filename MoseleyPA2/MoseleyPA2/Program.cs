using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoseleyPA2
{
    class Program
    {
        static void Main(string[] args)
        {
            string shirtChoiceInput, sizeInput;

            Console.WriteLine("\tWelcome to the Shirt Purchasing Application");
            Console.WriteLine(); //intentionally left blank

            Console.WriteLine("Please select a shirt: ");
            Console.WriteLine("\t(A) T-Shirt");
            Console.WriteLine("\t(B) Sweatshirt");
            Console.Write("\t>> ");
            shirtChoiceInput = Console.ReadLine();

            switch (shirtChoiceInput)

            {
                case "a":
                case "A":

                    shirtChoiceInput = "T-Shirt";

                    Console.WriteLine("Please select a size: ");
                    Console.WriteLine("\t(S) Small");
                    Console.WriteLine("\t(M) Medium");
                    Console.WriteLine("\t(L) Large");
                    Console.Write("\t>> ");
                    sizeInput = Console.ReadLine();

                    switch (sizeInput)
                    {
                        case "S":
                        case "s":

                            sizeInput = "Small";
                            Console.WriteLine("Enjoy your {0} {1}!", sizeInput, shirtChoiceInput);
                            break;

                        case "M":
                        case "m":

                            sizeInput = "Medium";
                            Console.WriteLine("Enjoy your {0} {1}!", sizeInput, shirtChoiceInput);
                            break;

                        case "L":
                        case "l":

                            sizeInput = "Large";
                            Console.WriteLine("Enjoy your {0} {1}!", sizeInput, shirtChoiceInput);
                            break;

                        default:
                            Console.WriteLine("Invalid Choice. Goodbye.");
                            break; // end of small med large invalid for t-shirt
                    }


                    break; //end of case a choosing t-shirt

                case "b":
                case "B":

                    shirtChoiceInput = "Sweatshirt";
                    Console.WriteLine("Please select a size: ");
                    Console.WriteLine("\t(S) Small");
                    Console.WriteLine("\t(M) Medium");
                    Console.WriteLine("\t(L) Large");
                    Console.Write("\t>> ");
                    sizeInput = Console.ReadLine();

                    switch (sizeInput)
                    {
                        case "S":
                        case "s":

                            sizeInput = "Small";
                            Console.WriteLine("Enjoy your {0} {1}!", sizeInput, shirtChoiceInput);
                            break;

                        case "M":
                        case "m":

                            sizeInput = "Medium";
                            Console.WriteLine("Enjoy your {0} {1}!", sizeInput, shirtChoiceInput);
                            break;

                        case "L":
                        case "l":

                            sizeInput = "Large";
                            Console.WriteLine("Enjoy your {0} {1}!", sizeInput, shirtChoiceInput);
                            break;

                        default:
                            Console.WriteLine("Invalid Choice. Goodbye.");
                            break; // end of small medium large and invalid choice for sweatshirt
                    }


                    break; //end of case b choosing a sweatshirt

                default:

                    Console.WriteLine("Invalid Choice.  Goodbye.");

                    break;

            }


            Console.ReadKey();






        }


    }
}
