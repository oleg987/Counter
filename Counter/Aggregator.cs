using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    public class Aggregator
    {
        public List<Item> Items { get; set; } = new List<Item>();
        public int FirstCounter { get; private set; }
        public int SecondCounter { get; private set; }

        public void Add(Item item)
        {
            if (!string.IsNullOrWhiteSpace(item.Str))
            {
                Items.Add(item);
            }
        }

        public void AddWithCounter(Item item)
        {
            if (item is FirstItem)
            {
                FirstCounter++;
            }

            if (item is SecondItem)
            {
                SecondCounter++;
            }

            Items.Add(item);
        }
    }
}
