using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class MachineOperations
    {
        public MachineOperations()
        {

            MoneyPool = 0;
        }

        //        const int[] Money = new int[] {1, 5, 10, 20, 50, 100, 500, 1000 };
        static readonly int[] Money = { 1, 5, 10, 20, 50, 100, 500, 1000 };
        public int MoneyPool { get; set; }

        public void PrintMenu()
        {
            Console.WriteLine("Welcome to AVM (Awesome Vending Machine). Money total: " + MoneyPool + "\n Please select an option:");
            Console.WriteLine("1 Input money\t\t2 List items\t\t3 Examine item\n4 Buy item\t\t5 Use item\t\t9 Money return");
        }

        public string GetInputFromConsole()
        {
            return Console.ReadLine();
        }

        /*
        public double GetNumberFromConsole(int min = 0, int max = 0)
        {
            double num;
            bool interval = false;
            if (min != 0 || max != 0)
            {
                interval = true;
            }
            while (true)
            {
                try
                {
                    num = Convert.ToDouble(Console.ReadLine());
                    if (!interval || (interval && num >= min && num <= max))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Valid numbers are between " + min + " and " + max + ": ");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Input error. Try again.");
                }
            }
            return num;
        }*/

    }


}