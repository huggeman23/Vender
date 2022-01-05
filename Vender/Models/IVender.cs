using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vender.Models
{
    public interface IVender
    {
        
        double pot();
        bool Purtches(int prise);
        void ShowAll(List<Products> products);
        void InsertMoney(int money);
        void EndTransaction();
        
    }
}
