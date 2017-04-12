using Bangazon_Terminal_App.consoleapp.DAL;
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
                    var customerRepository = new CustomerRepository();

                    Console.WriteLine("Enter your name");
                    var CustomerName = Console.ReadLine();

                    Console.WriteLine("Street address");
                    var CustomerAddress = Console.ReadLine();

                    Console.WriteLine("City");
                    var CustomerCity = Console.ReadLine();

                    Console.WriteLine("State");
                    var CustomerState = Console.ReadLine();

                    Console.WriteLine("Postal code");
                    var CustomerZip = int.Parse(Console.ReadLine());

                    Console.WriteLine("Phone number");
                    var CustomerPhone = int.Parse(Console.ReadLine());

                    customerRepository.AddCustomer(CustomerName, CustomerAddress, CustomerCity, CustomerState, CustomerZip, CustomerPhone);

                }
                else if (Command == "2")
                {
                    var customerRepository = new CustomerRepository();
                    
                    Console.Clear();
                    Console.WriteLine("Choose which customer will be active.");
                    customerRepository.GetCustomers();

                    var customerCollection = customerRepository.GetCustomers();

                    var cursorIndex = 0;
                    var continueLooping = true;

                    ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
                    while (continueLooping)
                    {
                        int counter = 0;

                        Console.Clear();

                        Console.WriteLine(!(keyInfo.KeyChar.Equals(ConsoleKey.Enter)));

                        Customer selectedCustomer = null;
                    foreach (var bangazonner in customerCollection)
                    {
                            if (counter == cursorIndex)
                            {
                                Console.WriteLine(">" + bangazonner.Name);
                                selectedCustomer = bangazonner;

                            }
                            else
                            {
                                Console.WriteLine(" " + bangazonner.Name);

                            }
                            counter++;
                    }

                        keyInfo = Console.ReadKey();
                        
                        if (keyInfo.Key == ConsoleKey.UpArrow)
                        {
                            cursorIndex--;
                        }
                        else if (keyInfo.Key == ConsoleKey.DownArrow)
                        {
                            cursorIndex++;
                        }
                        if (keyInfo.Key == ConsoleKey.Enter)
                        {
                            Console.Clear();
                            Console.WriteLine("Welcome" + selectedCustomer.Name);
                            continueLooping = false;
                        }
                  }

                    Console.WriteLine("outside loop test");
                    Console.Clear();
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