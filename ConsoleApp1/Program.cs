using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           // int num=2147483648;
           int num=-2147483648;
            //int num = -31;
            Console.WriteLine(Convert.ToString(num, 2));
            Console.ReadLine();
        }
    }
}
 

