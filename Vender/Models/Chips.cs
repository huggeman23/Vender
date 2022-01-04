using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vender.Models
{
    public class Chips : Products
    {
        public Chips(int id, string type, int pri) : base(id, type, pri)
        {
        }
        public override string Examin()
        {
            return $"{this.Type} prise:{this.prise}kr position: {this.ID}";
        }
        public override string Use()
        {
            return "eat chips";
        }
    }
}
