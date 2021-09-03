using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    public class Item
    {
        public static int counter = 0; // Counter of all(!) created objects.

        public string Str { get; set; }

        public Item()
        {
            ++counter;
        }

        public Item(string str) : this() // <- Calling inner constructor. 
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentNullException();
            }
        }
    }

    public class FirstItem : Item
    {

    }

    public class SecondItem : Item
    {

    }
}
