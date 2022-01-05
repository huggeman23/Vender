using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vender.Models
{
    public class Chips : Products
    {
        public Chips(int id, string name) : base(id, name)
        {
            Type = "Chips";
            prise = 20;
        }
        public override string Examin()
        {
            return $"{Name} type:{Type} prise:{prise}kr position: {ID}";
        }
        public override string Use()
        {
            return $"eat {Name}";
        }
    }
}
