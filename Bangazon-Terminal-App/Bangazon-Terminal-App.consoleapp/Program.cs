﻿using System;
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
                Console.Write("WELCOME TO BANGAZON!!!");

                string Command = Console.ReadLine();

                if (Command == "1")
                {
                    //CreateCustomer();
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