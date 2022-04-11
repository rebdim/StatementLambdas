using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatementLambdaS3
{
    public delegate int SubDelegate(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            int c = new SubDelegate((s, d) =>
            {
                int res = s - d;
                return res;
            }).Invoke(9, 6);
            Console.WriteLine(c);
            Console.ReadKey();

        }
    }
}
