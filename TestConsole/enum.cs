using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        enum type1
        {
            sunday,
            monday,
            tuesday = 5,

        };
        static void Main(string[] args)
        {

                int value = (int)type1.monday;
                int value2 = (int)type1.tuesday;
                string value1 = Convert.ToString(type1.sunday);
                string value3 = Convert.ToString(type1.tuesday);
                string value11 = type1.sunday + "";
                type1 val = type1.sunday;
                Console.WriteLine(value);
                Console.WriteLine(value2);
                Console.WriteLine(value3);
                Console.WriteLine(value1);
                Console.WriteLine(value11);
                Console.WriteLine(val);
                Console.ReadKey();
        }
    }

    //out put-1,5,sunday,sunday ,



}
