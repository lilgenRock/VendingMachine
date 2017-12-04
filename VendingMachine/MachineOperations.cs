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

        static readonly int[] Money = { 1, 5, 10, 20, 50, 100, 500, 1000 };
        public int MoneyPool { get; set; }

        public void PrintMenu()
        {
            Console.WriteLine("Welcome to AVM (Awesome Vending Machine). Money total: " + MoneyPool + "\n Please select an option:");
            Console.WriteLine("1 Input money\t\t2 List items\t\t3 Examine item\n4 Buy item\t\t5 Use item\t\t6 List bought items\t\t9 Money return");
        }

        public void InputMoney()
        {
            int input = -1;
            Console.WriteLine("This AVM accepts the following: 1, 5, 10, 20, 50, 100, 500, 1000. Please input your amount. Exit with 0.");
            while (input != 0)
            {
                input =  Convert.ToInt32(GetNumberFromConsole()); //input = sc.nextInt();
                if (IsValidMoney(Money, input))
                {
                    AddToMoneyPool(input);
                    Console.WriteLine("Thank you for your input. Total money input is now " + MoneyPool);
                    Console.WriteLine("Input more money? Exit money input with 0.");
                }
                else if (input != 0)
                {
                    Console.WriteLine("The AVM does not accept this value.");
                }
            }
        }

        public void AddToMoneyPool(int moneyPool)
        {
            MoneyPool += moneyPool;
        }
        public bool IsValidMoney(int[] arr, int targetValue)
        {
            foreach (int s in arr)
            {
                if (s == targetValue)
                {
                    return true;
                }
            }
            return false;
        }

        public void PrintItemList(Item[] items)
        {
            int counter = 0;
            String newLineCode = "";
            foreach (Item i in items)
            {
                Console.WriteLine(newLineCode + i.Selection + ". " + i.Name + " " + i.Price + "kr\t\t\t");
                counter++;
                newLineCode = (counter % 3 == 0) ? "\n" : "";
            }
            Console.WriteLine("");
        }
        
        public void BuyItem(Item[] items)
        {
            PrintItemList(items);
            Console.WriteLine("Select item to buy: ");
            int input = Convert.ToInt32(GetNumberFromConsole());
            Item exItem = GetItemBySelection(items, input);
            int cost = exItem.Purchase(MoneyPool);
            MoneyPool = MoneyPool - cost;
        }

        public void UseItem(Item[] items)
        {
            PrintItemList(items);
            Console.WriteLine("Select item to use: ");
            int input = Convert.ToInt32(GetNumberFromConsole());
            Item exItem = GetItemBySelection(items, input);
            exItem.Use();
        }

        public void TestItem(Item[] items)
        {
            PrintItemList(items);
            Console.WriteLine("Select item to examine: ");
            int input = Convert.ToInt32(GetNumberFromConsole());
            Item exItem = GetItemBySelection(items, input);
            exItem.Examine();
        }

        public Item GetItemBySelection(Item[] items, int number)
        {
            foreach (Item item in items)
            {
                if (item.Selection == number)
                {
                    return item;
                }
            }
            return null;
        }

        public Item[] FillMachineWithProducts()
        {
            Item[] newItems = new Item[9];
            newItems[0] = new Food("Big Mac", 79, 11, "A burger from McDonalds!");
            newItems[1] = new Food("Hawaii", 85, 12, "The pizza with pineapple!");
            newItems[2] = new Food("Kebab salad", 87, 13, "Kebab is it!");
            newItems[3] = new Drink("Red Bull", 28, 21, "Makes you fly!");
            newItems[4] = new Drink("Fanta", 22, 22, "Fantastic!");
            newItems[5] = new Drink("Beer", 49, 23, "Probably the best in the world!");
            newItems[6] = new Snack("Snickers", 14, 31, "Have a break!");
            newItems[7] = new Snack("Twix", 15, 32, "Twix it!");
            newItems[8] = new Snack("Protein Bar", 20, 33, "Makes you stronger!");
            return newItems;
        }

        public void ExitHandler()
        {
            ReturnChange();
            Console.WriteLine("Thank you for using AVM. Have a nice day!");
            Console.ReadLine();
        }

        public void ReturnChange()
        {
            int moneyPool = MoneyPool;
            Console.WriteLine("Your money pool is: " + moneyPool + ". Calculating your change:");

            for (int i = Money.Length - 1; i >= 0; i--)
            {
                if (moneyPool >= Money[i])
                {
                    int amount = moneyPool / Money[i];
                    Console.WriteLine(Money[i] + "x" + amount);
                    moneyPool -= Money[i] * amount;
                }
            }
        }

        public string GetInputFromConsole()
        {
            return Console.ReadLine();
        }
        
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
        }
    }
}