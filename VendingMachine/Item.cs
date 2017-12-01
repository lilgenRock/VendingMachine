using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public abstract class Item
    {
        string name;
        int price;
        int selection;
        string info;

        public abstract void Purchase();
        public abstract void Examine();
        public abstract void Use();


    }
}
