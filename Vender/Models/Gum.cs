using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vender.Models
{
    public class Gum : Products
    {
        public Gum(int id, string name) : base(id, name)
        {
            Type = "Gum";
            prise = 12;
        }
        public override string Examin()
        {
            return $"{Name} type:{Type} prise:{prise}kr position: {ID}";
        }
        public override string Use()
        {
            return $"chew {Name}";
        }
    }
}
