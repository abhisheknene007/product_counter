using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_counter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();

            Console.WriteLine("Total number of Units :");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
            start: Console.WriteLine("Enter Type :");
                   string type = Console.ReadLine();
                if (type.ToUpperInvariant() == "A" ||
                    type.ToUpperInvariant() == "B" ||
                    type.ToUpperInvariant() == "C" ||
                    type.ToUpperInvariant() == "D")
                {
                    Item p = new Item(type.ToUpperInvariant());
                    items.Add(p);
                }else
                {
                    Console.WriteLine("\nEntered wrong type .. !!");
                    goto start;
                }
            }

            int totalPrice = Item.GetTotalPrice(items);
            Console.WriteLine("\nTotal price after cart items run : "+totalPrice);
            Console.ReadLine();
        }

       
    }
}
