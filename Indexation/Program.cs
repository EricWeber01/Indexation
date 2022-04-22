using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexation
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Arr a = new Arr(-3, 5);
            int ind = -1;
            Console.WriteLine(a[ind]);*/
            People p = new People();
            Console.WriteLine(p["Денис"]);
            Console.WriteLine(p[20]);
        }
    }
}
