using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicaloperator2
{
    class code
    {
        static void Main(string[] args)
        {
            int a=5;
            int b = 6;
            if (a != b)
            {
                Console.WriteLine(+a +"is not equal to" + b);
                if(a<b)
                {
                    Console.WriteLine("a is small");
                }
                else
                {
                    Console.WriteLine("b is small");
                }
            }
            else if(a!=0 && b!=0)
                {
                Console.WriteLine("a and b are not equal to zero");
                    }
            else
            {
                Console.WriteLine("they are zeroo");
            }
            Console.ReadKey();
        }
    }
}
