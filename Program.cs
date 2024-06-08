using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_5
{
    public class Store
    {
        public int NumGoods { get; protected set; }

        public Store(int num)
        {
            if (num < 0) throw new ExceptionGoods();
            NumGoods = num;
        }

        public void Removal(int num)
        {
            try
            {
                NumGoods -= num;
                if (NumGoods < 0) throw new ExceptionGoods();
            }
            catch (ExceptionGoods e)
            {
                NumGoods = 0;
                Console.WriteLine($"Ошибка! Товаров меньше 0!");
            }    
            
            Console.WriteLine($"На складе осталось {NumGoods} товара");
        }
    }
}
