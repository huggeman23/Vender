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
        public List<Products> collect = new List<Products>();
        public void addProduct(string Type, string name)
        {
            int pID = collect.Count() + 1;
            switch (Type) {
                case "Drink":
                      Drink drink = new Drink(pID, name);
                      collect.Add(drink);
                break;

                case "Chips":
                      Chips chips = new Chips(pID, name);
                      collect.Add(chips);
                break;

                case "Gum":
                      Gum gum = new Gum(pID, name);
                      collect.Add(gum);
                break;
            }

        }
        static void Main(string[] args)
        {
        Program program = new Program();
        IVender vend = new Vending();

            program.addProduct("Drink", "sprite");
            program.addProduct("Chips", "dill");
            program.addProduct("Chips", "cheese");
            program.addProduct("Gum", "extra");
            program.addProduct("Drink", "fanta");
            bool loop = true;
            while (loop==true)
            {
                
                Console.WriteLine("curent amount: "+vend.pot());
                
                Console.WriteLine("show products(1), Insert mouney(2), exit and get change back(3)");
                
                int.TryParse(Console.ReadLine(), out int meny);
                switch (meny)
                {
                    case 1:
                        vend.ShowAll(program.collect);
                        int.TryParse(Console.ReadLine(), out int id);
                        foreach (var c in program.collect)
                        {
                            if (c.ID == id)
                            {

                                Console.WriteLine(c.Examin());
                                Console.WriteLine("purches write (1)");

                                int.TryParse(Console.ReadLine(), out int select);
                                
                                if (select == 1 && vend.Purtches(c.prise))
                                    {
                                    Console.WriteLine(c.Name + " was purtchesed would you like to use it write (1) if so");
                                    int.TryParse(Console.ReadLine(), out int use);

                                    if (use == 1)
                                    {
                                        Console.WriteLine(c.Use());
                                    }
                                }
                                
                            }
                        }
                        break;

                    case 2:
                        Console.WriteLine("insert money into the mechine");
                        int.TryParse(Console.ReadLine(), out int insert);
                        vend.InsertMoney(insert);
                        break;
                    case 3:
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
