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
            Item[] items = new Item[0];
            items = vm.FillMachineWithProducts();

            while (!input.Equals("9"))             // Exit loop if 9(Money return) is selected
            {        
                vm.PrintMenu();
                input = vm.GetInputFromConsole();
                if (input.Equals("1"))             // Input money
                {
                    vm.InputMoney();
                }
                else if (input.Equals("2"))        // List all items in vending machine
                {
                    vm.PrintItemList(items);
                }
                else if (input.Equals("3"))        // Examine item
                {
                    vm.TestItem(items);
                }
                else if (input.Equals("4"))        // Buy item
                {
                    vm.BuyItem(items);
                }
                else if (input.Equals("5"))        // Use item
                {
                    vm.UseItem(items);
                }
                else if(!input.Equals("9"))        // Input error
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
            vm.ExitHandler();
        }
    }
}