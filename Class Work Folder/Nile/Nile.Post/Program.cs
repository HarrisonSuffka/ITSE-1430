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
                    case 'a':
                    case 'A': AddProduct(); break;
                    case 'l':
                    case 'L': ListProducts(); break;
                    case 'q':
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
            string price = Console.ReadLine().Trim();

            Console.Write("Enter product description: ");
            productDescription = Console.ReadLine().Trim();

            Console.Write("Enter if product is discontinued: ");
            string discontinued = Console.ReadLine().Trim();
        }

        private static void ListProducts()
        {
            throw new NotImplementedException();
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
                if (input != null && input.Length == 0)
                {
                    //String comparrision
                    if (String.Compare(input, "A", true) == 0)
                        return 'A';

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

        //PRODUCT
        static string productName;
        static decimal productPrice;
        static string productDescription;
        static bool productDiscontinued;
    }
}
