using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vender.Models
{
    public abstract class Products : Collection
    {
        public Products(int id, string type, int pri) : base(id, type, pri)
        {
        }
        public abstract string Examin();

        public abstract string Use();

    }
}
