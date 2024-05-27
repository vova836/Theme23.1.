using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    enum Days
    {
        Sat, Sun, Mon, Tue, Wed, Thu, Fri
    }

    class Program
    {
        static void Main(string[] args)
        {
            Days i;
            for (i = Days.Sat; i <= Days.Fri; i++)
            Console.WriteLine(i+ "имеет значение" +(int)i);
            Console.ReadKey();
        }
    }
}
