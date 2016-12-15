using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestConsole
{
    class StringPreoperties
    {
        static void Main()
        {
            //string sepration

            string value = "cat\r\ndog\r\nanimal\r\nperson";
            // Split the string on line breaks.
            // ... The return value from Split is a string array.
            string[] lines = Regex.Split(value, "\r\n");

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            string value1 = "man,woman,child,,,bird";
            char[] delimiter1 = new char[] { ',' };   // <-- Split on these

            // ... Use StringSplitOptions.None.
            string[] array1 = value1.Split(delimiter1,
                StringSplitOptions.None);

            foreach (string entry in array1)
            {
                Console.WriteLine(entry);
            }
            string[] array2 = value1.Split(delimiter1,
        StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine();
            foreach (string entry in array2)
            {
                Console.WriteLine(entry);
            }
            string s = "there is a cat";
            // Split string on spaces.
            // ... This will separate all the words.
            string[] words = s.Split(' ');
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();

        }

    }
}
