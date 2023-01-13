using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlog.TypeVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            string aToString = a.ToString();
            Console.WriteLine(a);
            Console.WriteLine(aToString);

            Console.WriteLine(a.GetType().ToString());
            Console.WriteLine(aToString.GetType().ToString());

            string b = "hello";
            Console.WriteLine(b);
            Console.WriteLine(b.GetType().ToString());
            Console.WriteLine(b.GetType().ToString());

            float c = 10f;
            string cToString = c.ToString();
            Console.WriteLine(c);
            Console.WriteLine(cToString);
            Console.WriteLine(c.GetType().ToString());
            Console.WriteLine(cToString.GetType().ToString());

            decimal d = 22m;
            string dToString = d.ToString();
            Console.WriteLine(d);
            Console.WriteLine(dToString);
            Console.WriteLine(d.GetType().ToString());
            Console.WriteLine(dToString.GetType().ToString());
        }
    }
}
