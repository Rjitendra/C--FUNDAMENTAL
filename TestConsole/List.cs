using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class List
    {

        static void Main(string[] args)
        {



            List<string> result = new List<string>(new string[]{"nile",
	    "amazon", // River 2.
	    "yangtze", // River 3.
	    "mississippi",
	    "yellow"});
            foreach (string river in result)
            {
                Console.WriteLine(river);
            }
            List<string> result1 = new List<string>();

            result1.Add("jitu");
            result1.Add("jitu");
            result1.Add("jitu");
            foreach (string river in result1)
            {
                Console.WriteLine(river);
            }
        
        }


    }
}
