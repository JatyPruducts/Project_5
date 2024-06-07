using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_5
{
    public class ExceptionGoods : Exception
    {
        public ExceptionGoods() : base("Такого товара нет!") { }
    }
}
