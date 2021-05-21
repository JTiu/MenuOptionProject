﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuOptionNamespace
{
    public class Program //does not need to run anything from here.
    {
        static void Main(string[] args)
        {
            Menu startMenu = new Menu();
            int optionPicked;
            optionPicked = startMenu.DrawMenu(); //

            while (optionPicked != 7)
            {
                Console.Clear();
                startMenu.DirectUser(optionPicked);
                Console.Clear();
                optionPicked = startMenu.DrawMenu();

            }

            Console.WriteLine("Press any button to exit application");

            Console.ReadKey();
        }
    }
}
