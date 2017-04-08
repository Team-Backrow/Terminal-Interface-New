using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangazon_Terminal_App.consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("*******************************************************");
                Console.WriteLine("** WELCOME TO BANGAZON! Command Line Ordering System **");
                Console.WriteLine("*******************************************************");

                Console.WriteLine("1.create a customer account");
                Console.WriteLine("2.choose active customer");
                Console.WriteLine("3.create a payment option");
                Console.WriteLine("4.add product to shopping cart");
                Console.WriteLine("5.complete an order");
                Console.WriteLine("6.see product popularity");
                Console.WriteLine("7.leave bangazon!");

               string Command = Console.ReadLine();

                if (Command == "1")
                {
                    Console.Clear();

                    //CreateCustomer();

                    Console.WriteLine("Enter your name");
                    Console.ReadLine();
                    Console.WriteLine("Street address");
                    Console.ReadLine();
                    Console.WriteLine("City");
                    Console.ReadLine();
                    Console.WriteLine("State");
                    Console.ReadLine();
                    Console.WriteLine("Postal code");
                    Console.ReadLine();
                    Console.WriteLine("Phone number");
                    Console.ReadLine();
                }
                else if (Command == "2")
                {
                    //Command = GetCustomer();
                }
                else if (Command == "3")
                {
                    //AddPayment();
                }
                else if (Command == "4")
                {
                    //AddProductToOrder();
                }
                else if (Command == "5")
                {
                    //CompleteOrder();
                }
                else if (Command == "6")
                {
                    //DisplayProductAvailability();
                }
                else if (Command == "7")
                {
                    Environment.Exit(0);
                }

            }

        }
    }
}