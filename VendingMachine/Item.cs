using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public abstract class Item
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Selection { get; set; }
        public string Info { get; set; }

        public abstract int Purchase(int moneyPool);
        public abstract void Examine();
        public abstract void Use();
    }
}