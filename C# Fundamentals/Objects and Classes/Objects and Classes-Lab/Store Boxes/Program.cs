using System;

namespace Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            Item car = new Item("bmw", 100000);
        }

    }














    class Item
    {
        public Item(string name,decimal price)
        {
            Name = name;
            Price = price;
            


        }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    
}
