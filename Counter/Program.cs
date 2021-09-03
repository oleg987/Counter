using System;

namespace Counter
{
    class Program
    {
        // Problem: How to count Item objects in Aggregator?

        static void Main(string[] args)
        {
            //Example1();
            //Example2();
            //Example3();
            Example4();
        }

        private static void Example1()
        {
            var aggr = new Aggregator();

            aggr.Items.Add(new Item());
            aggr.Items.Add(new Item());
            aggr.Items.Add(new Item());

            Console.WriteLine(Item.counter);        // Output: 3 -> Well done!
            Console.WriteLine(aggr.Items.Count);    // Output: 3 -> Well done!

            // A few moments later...

            var aggr2 = new Aggregator();

            aggr2.Items.Add(new Item());
            aggr2.Items.Add(new Item());
            aggr2.Items.Add(new Item());

            Console.WriteLine(aggr2.Items.Count);   // Output: 3 -> Well done!
            Console.WriteLine(Item.counter);        // Output: 6 -> Ooups!
        }

        // Add to item constructor with string argument. String must be not empty.
        private static void Example2()
        {
            var aggr = new Aggregator();

            aggr.Items.Add(new Item());
            aggr.Items.Add(new Item());
            aggr.Items.Add(new Item());

            try
            {
                aggr.Items.Add(new Item(""));
            }
            catch (Exception e)
            {
                Console.WriteLine("Houston, we have a problem!");
            }

            Console.WriteLine(Item.counter);        // Output: 4
            Console.WriteLine(aggr.Items.Count);    // Output: 3

            // Same problem with exceptions throwing through the hierarchy.
        }

        /* 1. Creating Add method in Aggregator.
         * 2. Creating string property Str in Item.
         * 3. Add validation in Aggregator.Add()
         */
        private static void Example3()
        {
            var aggr = new Aggregator();

            aggr.Add(new Item());
            aggr.Add(new Item());
            aggr.Add(new Item());
            aggr.Add(new Item("Valid Item"));

            Console.WriteLine(Item.counter);        // Output: 4
            Console.WriteLine(aggr.Items.Count);    // Output: 1
        }

        /*
         * 1. Create FirstItem inherited from Item.
         * 2. Create SecondItem inherited from Item.
         * 3. Add int property FirstCounter to Aggregator.
         * 4. Add int property SecondCounter to Aggregator.
         * 5. Add AddWithCounter method to Aggregator.
         */
        private static void Example4()
        {
            var aggr = new Aggregator();

            aggr.Add(new FirstItem());            
            aggr.Add(new SecondItem());
            aggr.Add(new FirstItem());

            Console.WriteLine(aggr.Items.Count);    // Output: 3 -> Ok!
            Console.WriteLine(aggr.FirstCounter);   // Output: 2 -> Ok!
            Console.WriteLine(aggr.SecondCounter);  // Output: 1 -> Ok!

            // Problem -> solved!
        }
    }
}
