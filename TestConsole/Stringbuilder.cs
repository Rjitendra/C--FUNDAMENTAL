using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Stringbuilder1
    {


        static void Main(string[] args)
        {
            string s = "jitendra";
            Console.WriteLine(s);
            s = "jitendra"; Console.WriteLine(s);
            s = s + "Behera";
            Console.WriteLine(s);
            StringBuilder sb = new StringBuilder("jitendra");
            sb.Append(" Behera");
            Console.WriteLine(sb);
            sb.Remove(0, 9);
            Console.WriteLine(sb);
            sb.Replace("Behera", "JITU");
            Console.WriteLine(sb);
            Console.ReadLine();




        }

    }
}
