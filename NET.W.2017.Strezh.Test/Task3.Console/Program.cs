using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock();
            Bank bank = new Bank("Bank of America", stock);
            Broker broker = new Broker("Rokefeller", stock);
            stock.Market();
            Console.ReadKey();
        }
    }
}
