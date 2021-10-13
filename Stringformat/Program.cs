using System;

namespace Stringformat
{
    class Program
    {
        static void Main(string[] args)
        {
             DateTime d = DateTime.Now;
            decimal num = 12.2574m;
            int n = 120000;
           Console.WriteLine("{0:D}",d);
            Console.WriteLine("{0:d}",d);
            Console.WriteLine("{0:F}", d);
            Console.WriteLine("{0:Y}", d);
            Console.WriteLine("{0:t}", d);
            Console.WriteLine("{0:T}", d);
            Console.WriteLine("{0:M}", d);
            Console.WriteLine("{0:g}", d);
            Console.WriteLine("{0:r}", d);
            Console.WriteLine("{0:s}", d);
            Console.WriteLine("{0:u}", d);
            Console.WriteLine("{0:U}", d);
        
            Console.WriteLine("{0:n}",num);
            Console.WriteLine("{0:12%}", n);
            Console.WriteLine("{0:0,0}",n);
            Console.WriteLine("{0:c}",num);

            Console.WriteLine(d.ToString("MM/dd/yyyy"));
            Console.WriteLine(d.ToString("yyyy/dd/MM"));
            Console.WriteLine(d.ToString("dd/MMMM/yyyy"));
            Console.WriteLine(d.ToString("dddd\t dd/MM/yyyy \t hh/mm/ss"));
            Console.ReadLine();
        }
    }
}