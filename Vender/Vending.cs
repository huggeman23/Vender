using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vender.Models;

namespace Vender.VendingMechine
{
        public class Vending
        {
            //public int[] Denominations = new int[400];
            public int[] Values = { 1000, 500, 100, 50, 20, 10, 5, 1 };
            public double sum;

            public bool Purtches(int prise)
            {
            bool purtchesCon;
                if (prise <= sum)
                {
                purtchesCon = true;
                    sum = sum - prise;
                }
                else
                {
                purtchesCon = false;
                    Console.WriteLine("You cant affor that. Pleas inset more money");

                }
                return purtchesCon;

            }
            public void ShowAll(List<Collection> products)
            {
            foreach (var product in products)
            {
                Console.WriteLine($"{product.ID}: {product.Type} ");
            }


            }
            public void InsertMoney(int money)
            {

                if (Values.Contains(money))
                {
                    sum = sum + money;
            }
            else
            {
                Console.WriteLine("not valid input");
            }
            }
            public void EndTransaction()
            {

                foreach (var val in Values)
                {
                    if (sum / val >= 1)
                    {
                        double amount = sum / val - (sum / val - (int)(sum / val));
                        sum = sum - amount * val;
                        Console.WriteLine(amount + " " + val + " kr");
                    }
                }
            }

        }
    }

