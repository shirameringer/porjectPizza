using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace porjectPizza.Interfaces
{
    public interface Iorder
    {
        void postOrder(string pizzaName,int count,string customerName);
       
    }
}