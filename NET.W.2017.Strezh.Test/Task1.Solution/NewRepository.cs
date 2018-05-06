using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class NewRepository : IRepository
    {
        public void Create(string password)
        {
            Console.WriteLine($"Password {password} was added");
        }
    }
}
