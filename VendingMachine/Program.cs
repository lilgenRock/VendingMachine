using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            MachineOperations vm = new MachineOperations();
            string input = "";

            while (!input.Equals("9"))
            {        // exit loop if 9(Money return) is selected
                vm.PrintMenu();
                input = vm.GetInputFromConsole();
                if (input.Equals("1"))               // Input money
                {
                    //     vm.inputMoney();
                }
                else if (input.Equals("2"))        // List all items
                {
                    //     vm.printItemList(items);
                }
                else if (input.Equals("3"))        // Examine item
                {
                    //     vm.testItem(items);
                }
                else if (input.Equals("4"))        // Buy item
                {
                    //     vm.buyItem(items);
                }
                else if (input.Equals("5"))        // Use item
                {
                    //     vm.useItem(items);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }

            }




        }
    }
}