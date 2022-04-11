using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatementLambdas
{
    public delegate void HelloDelegate(string s);
    class Program
    {
        static void Main(string[] args)
        {
            HelloDelegate hD = (x) => { Console.WriteLine("Привет, " + x); };

            hD("Вася");

            Console.ReadKey();
        }
    }
}
