using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class stringcompaire
    {
       // static int k = 0;

        public static void Main()
        {
            Console.WriteLine("enter str1");
            string str1 = Console.ReadLine();
            Console.WriteLine("enter str2");
            string str2 = Console.ReadLine();
            char[] array1 = str1.ToCharArray();
            char[] array2 = str2.ToCharArray();
            string[] array3 = new string[0];
            ArrayList list = new ArrayList();
            var listOfStrings = new List<string>();
            StringBuilder sbr = new StringBuilder();
            for (int i = 0; i < array1.Length; i++)
            {
                int G = 1;
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array2[j] == array1[i])
                    {
                        G++;
                    }
                }
                if (G == 1)
                { list.Add(array1[i].ToString()); }
            }
            if (list.Count == 0)
            {
                sbr.Append("NULL");
               // Console.WriteLine("NULL");

            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    sbr.Append(list[i].ToString());
                    
                }
            }
            string Data = sbr.ToString();
             string Result=new String(Data.Distinct().ToArray());
            Console.WriteLine("output is :-  {0}", Result);
            Console.ReadLine();
        }


    }
}
