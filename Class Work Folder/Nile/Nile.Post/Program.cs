/*
 * Harrison Suffka
 * ITSE 1430
 * Nile.Host
 */ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nile.Post 
    {
    class Program 
        {
        static void Main( string[] args )
        {
            bool quit = false;
            do
            {
                char choice = GetInput();

                switch (choice)
                {
                    case 'A': AddProduct(); break;
                    case 'L': ListProducts(); break;
                    case 'Q': quit = true; break;
                }
            } while (!quit);
        }

        private static void AddProduct()
        {
            Console.Write("Enter product name: ");
            productName = Console.ReadLine().Trim();

            //Ensure not empty

            Console.Write("Enter product price (> 0): ");
            productPrice = ReadDecimal();

            Console.Write("Enter product description: ");
            productDescription = Console.ReadLine().Trim();

            Console.Write("Enter Y/N if product is discontinued: ");
            productDiscontinued = ReadYesNo();
        }

        private static void ListProducts()
        {
            //Name Price [Discontinued]
            //Description
            //string msg = String.Format("{0}\t\t\t${1}\t\t{2}", productName, productPrice, productDiscontinued ? "[Discontinued]" : "");
            //Console.WriteLine("{0}\t\t\t${1}\t\t{2}", productName, productPrice, productDiscontinued ? "[Discontinued]" : "")
            string msg = $"{productName}\t\t\t${productPrice}\t\t{(productDiscontinued ? "[Discontinued] " : "")}";

            Console.WriteLine(msg);

            Console.WriteLine(productDescription);
        }

        static char GetInput ()
        {
            while (true)
            {
                Console.WriteLine("Main Menu");
                Console.WriteLine("".PadLeft(10), '-');
                Console.WriteLine("A)dd Product");
                Console.WriteLine("L)ist Products");
                Console.WriteLine("Q)uit");

                string input = Console.ReadLine();

                //option 1 = string literal
                //if (input != "")
                //{
                //    char letter = Char.ToUpper(input[0]);
                //    if (letter == 'A' /*|| input == "a"*/)
                //        return 'A';
                //    else if (letter == 'L' /*|| input == "l"*/)
                //        return 'L';
                //    else if (letter == 'Q' /*|| input =="q"*/)
                //        return 'Q';
                //}

                //Option 2 string field
                //if (input != String.Empty)
                //{
                //    char letter = Char.ToUpper(input[0]);
                //    if (letter == 'A' /*|| input == "a"*/)
                //        return 'A';
                //    else if (letter == 'L' /*|| input == "l"*/)
                //        return 'L';
                //    else if (letter == 'Q' /*|| input =="q"*/)
                //        return 'Q';
                //}

                //Option 3 length
                if (input != null && input.Length != 0)
                {
                    //String comparison
                    //if (String.Compare(input, "A", true) == 0)
                    //    return 'A';

                    char letter = Char.ToUpper(input[0]);
                    if (letter == 'A' /*|| input == "a"*/)
                        return 'A';
                    else if (letter == 'L' /*|| input == "l"*/)
                        return 'L';
                    else if (letter == 'Q' /*|| input =="q"*/)
                        return 'Q';
                }

                //Error
                Console.WriteLine("Please choose a valid option");
            }
 
        }
        static void Main2( string[] args )
        {
            int hours = 3;
            var name = "Harrison";
            
            //Format 1
            string format1 = name + " worked " + hours.ToString() + " hours";

            //Format 2
            string format2 = String.Format("(0) worked for (1) hours", name, hours);

            //Format 3
            string format3 = $" {name} worked for {hours} hours";
            // $ will basically do format 2 automatically also its complier safe 
        }

        /// <summary>Reads a decimal from Console/// </summary>
        /// <returns>The decimal value</returns>
        static decimal ReadDecimal()
        {
            do
            { 
            string input = Console.ReadLine();

            decimal result;
            if (Decimal.TryParse(input, out result))
                return result;

                Console.WriteLine("Enter a valid decimal");
            } while (true) ;
        }

        static bool ReadYesNo()
        {
            do
            {
                string input = Console.ReadLine();

                if (!String.IsNullOrEmpty(input))
                {
                    switch (Char.ToUpper(input[0]))
                    {
                        case 'Y': return true;
                        case 'N': return false;
                    }
                }

                Console.WriteLine("Enter either Y or N");
            } while (true);
        }

        //PRODUCT
        static string productName;
        static decimal productPrice;
        static string productDescription;
        static bool productDiscontinued;
    }
}
