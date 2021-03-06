﻿using Bangazon_Terminal_App.consoleapp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangazon_Terminal_App.consoleapp
{
    public class Program
    {
        static Customer activeCustomer = null;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("*******************************************************");
                Console.WriteLine("** WELCOME TO BANGAZON! Command Line Ordering System **");
                Console.WriteLine("*******************************************************");
                if (activeCustomer == null) 
                {
                    Console.WriteLine("1.create a customer account");
                    Console.WriteLine("2.choose active customer"); 
                }
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
                    
                    Console.WriteLine(activeCustomer.CustomerID); 
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

                    foreach (var bangazonner in customerCollection)
                    {
                            if (counter == cursorIndex)
                            {
                                Console.WriteLine(">" + bangazonner.Name);
                                activeCustomer = bangazonner;

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
                            Console.WriteLine("Welcome, " + activeCustomer.Name + " Choose an option below!");
                            continueLooping = false;
                        }
                  }

                    Console.WriteLine(" ");
                    
                }
                else if (Command == "3")
                {
                    //AddPayment();
                    Console.Clear();
                    var paymentRepository = new PaymentRepository();

                    Console.WriteLine("Enter your payment type (i.e. credit/debit card)");
                    var PaymentType = Console.ReadLine();

                    Console.WriteLine("Enter Account Number");
                    var AccountNumber = Console.ReadLine();

                    paymentRepository.AddPayment(PaymentType, AccountNumber, activeCustomer.CustomerID);

                    new Customer();

                    Console.WriteLine("Payment method has been added!");
                }
                else if (Command == "4")
                {
                    //AddProductToOrder();
                    var productRepository = new ProductRepository();

                    Console.Clear();
                    Console.WriteLine("Choose which customer will be active.");
                    productRepository.GetProducts();

                    var productCollection = productRepository.GetProducts();

                    var cursorIndex = 0;
                    var continueLooping = true;

                    ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
                    while (continueLooping)
                    {
                        int counter = 0;

                        Console.Clear();

                        Console.WriteLine(!(keyInfo.KeyChar.Equals(ConsoleKey.Enter)));

                        foreach (var product in productCollection)
                        {
                            if (counter == cursorIndex)
                            {
                                Console.WriteLine(">" + product.ProductName);
                                //activeCustomer = product;

                            }
                            else
                            {
                                Console.WriteLine(" " + product.ProductName);

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
                            continueLooping = false;
                        }
                    }

                    Console.WriteLine(" ");

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