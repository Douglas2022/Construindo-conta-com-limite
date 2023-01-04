using Coursetry.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursetry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BussinesAcount acount = new BussinesAcount(800,"Bob",100.0,500.0);

            Console.WriteLine(acount.Balance);
        }
    }
}
