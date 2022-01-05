using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vender.Models
{
    public abstract class Products
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public int prise { get; set; }

        public Products(int id, string name)
        {
            ID = id;
            Name = name;
        }
        
        public abstract string Examin();

        public abstract string Use();

    }
}
