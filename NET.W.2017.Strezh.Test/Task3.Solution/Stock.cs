using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Stock 
    {
        public event EventHandler<StockEventArgs> changeStocks = delegate { };

        public void Market()
        {
            var changeSt = new StockEventArgs();
            Random rnd = new Random();
            changeSt.USD = rnd.Next(20, 40);
            changeSt.Euro = rnd.Next(30, 50);
            OnChangeStock(changeSt);
        }

        protected virtual void OnChangeStock(StockEventArgs e) => changeStocks(this, e);
    }
}
