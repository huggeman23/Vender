using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vender.VendingMechine;
using Vender.Models;

namespace Vender
{

    public class Program
    {   
        static void Main(string[] args)
        {
        Vending vend = new Vending();

        Drink drink = new Drink(1,"Drink",15);
        Chips chips = new Chips(2, "Chips", 20);
        Gum gum = new Gum(3, "Gum", 12);
       
            List<Collection> collect = new List<Collection>();
                       
            collect.Add(drink);
            collect.Add(chips);
            collect.Add(gum);
            
            bool loop = true;
            while (loop==true)
            {
                
                Console.WriteLine("curent amount: "+vend.sum);
                vend.ShowAll(collect);
                Console.WriteLine("Insert mouney(4), exit and get change back(5)");
                
                int.TryParse(Console.ReadLine(), out int meny);
                switch (meny)
                {
                    case 1:
                    case 2:
                    case 3:
                        foreach (var c in collect)
                        {
                            if (c.ID == meny)
                            {
                                var t = (c as Products);

                                Console.WriteLine(t.Examin());
                                Console.WriteLine("purches write (1)");

                                int.TryParse(Console.ReadLine(), out int select);
                                
                                if (select == 1 && vend.Purtches(c.prise))
                                    {
                                    Console.WriteLine(c.Type + " was purtchesed would you like to use it write (1) if so");
                                    int.TryParse(Console.ReadLine(), out int use);

                                    if (use == 1)
                                    {
                                        Console.WriteLine(t.Use());
                                    }
                                }
                                
                            }
                        }
                        break;

                    case 4:
                        Console.WriteLine("insert money into the mechine");
                        int.TryParse(Console.ReadLine(), out int insert);
                        vend.InsertMoney(insert);
                        break;
                    case 5:
                        vend.EndTransaction();
                        loop= false;
                        break;
                }
                Console.ReadLine();
                Console.Clear();

            }
           
        }
    }
}
