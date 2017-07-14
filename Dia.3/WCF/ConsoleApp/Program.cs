using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference.Service1Client cli = new ServiceReference.Service1Client();

            string data = cli.GetData(7845);
        }
    }
}
