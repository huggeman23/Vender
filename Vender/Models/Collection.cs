using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vender.Models
{
    public class Collection
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public int prise { get; set; }

        public Collection(int id, string type, int pri)
        {
            ID = id;
            Type = type;
            prise = pri;
        }
    }
}
