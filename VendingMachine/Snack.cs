using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Snack : Item
    {
        public Snack(string name, int price, int selection, string info)
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
                Console.WriteLine("You have now bought the following snack: " + Name);
                return Price;
            }
            else
            {
                Console.WriteLine("The money pool is not large enough for this snack. Please input more money first.");
                return 0;
            }
        }

        public override void Examine()
        {
            Console.WriteLine("This food has the following info: " + Info);
        }

        public override void Use()
        {
            Console.WriteLine("You are now eating this snack: " + Name);
        }
    }
}