using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerchio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cerchio c = new Cerchio();
            c.Raggio = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} \n{1}", c.Perimetro(), c.Area());
            Console.WriteLine("{0}", c.ToString());
            Console.ReadLine();
        }
    }
}
