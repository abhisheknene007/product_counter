using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro_counter
{
    class Item
    {
        public string Id { get; set; }
        public decimal Price { get; set; }


        public Item(string id)
        {
            this.Id = id;
            switch (id)
            {
                case "A":
                    this.Price = 50m;

                    break;
                case "B":
                    this.Price = 30m;

                    break;
                case "C":
                    this.Price = 20m;

                    break;
                case "D":
                    this.Price = 2015m;
                    break;
            }
        }

        public static int GetTotalPrice(List<Item> products)
        {
            int countA = 0;
            int priceA = 50;
            int countB = 0;
            int priceB = 30;
            int countC = 0;
            int priceC = 20;
            int countD = 0;
            int priceD = 15;
            foreach (Item pr in products)
            {
                if (pr.Id == "A" || pr.Id == "a")
                {
                    countA = countA + 1;
                }
                if (pr.Id == "B" || pr.Id == "b")
                {
                    countB = countB + 1;
                }
                if (pr.Id == "C" || pr.Id == "c")
                {
                    countC = countC + 1;
                }
                if (pr.Id == "D" || pr.Id == "d")
                {
                    countD = countD + 1;
                }
            }
            int totalA = (countA / 3) * 130 + (countA % 3 * priceA);
            int totalB = (countB / 2) * 45 + (countB % 2 * priceB);
            int totalC = (countC * priceC);
            int totalD = (countD * priceD);
            return totalA + totalB + totalC + totalD;

        }
    }
}
