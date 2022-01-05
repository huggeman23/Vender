using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vender.Models
{
    public class Drink : Products
    {
        public Drink(int id, string name) : base(id, name)
        {
            Type = "Drink";
            prise = 15;
        }
        public override string Examin()
        {
            return $"{Name} type:{Type} prise:{prise}kr position: {ID}";
        }
        public override string Use()
        {
            return $"drink {Name}";
        }


    }
}
