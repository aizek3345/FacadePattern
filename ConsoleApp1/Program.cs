using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadePattern;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.OperationAB();
            facade.OperationBC();
        }
    }
}
