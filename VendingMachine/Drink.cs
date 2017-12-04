using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Drink : Item
    {
        public Drink(string name, int price, int selection, string info)
        {
            Name = name;
            Price = price;
            Selection = selection;
            Info = info;
        }
        public override int Purchase(int moneyPool)
        {
            if (moneyPool >= Price)
            {
                Console.WriteLine("You have now bought the following drink: " + Name);
                return Price;
            }
            else
            {
                Console.WriteLine("The money pool is not large enough for this drink. Please input more money first.");
                return 0;
            }
        }

        public override void Examine()
        {
            Console.WriteLine("This drink has the following info: " + Info);
        }

        public override void Use()
        {
            Console.WriteLine("You are now drinking: " + Name);
        }
    }
}