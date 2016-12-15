using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class DistinctLetter
    {
        public static void Main()
        {
            Console.WriteLine("Enter the Name");
            string Name = Console.ReadLine();
            char[] array = Name.ToCharArray();
            ArrayList list = new ArrayList();
            for (int i = 0; i < array.Length; i++)
            {
                int increament = 1;
                for (int j = 0; j <= array.Length - 1; j++)
                {

                    if (array[i] == array[j])
                    {
                        increament++;


                    }

                }
                if (increament == 2)
                {

                    list.Add(array[i]);

                }


                else
                {
                    int inrincreament = 1;
                    for (int l = 0; l < list.Count; l++)
                    {
                       
                        if (array[l] == array[i])
                        {
                            inrincreament++;

                        }

                     }
                    if (inrincreament == 1)
                    {

                        list.Add(array[i]);

                    }

                }
            }

            Console.WriteLine("output is : ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].ToString());

            }

            Console.ReadLine();
        
        Main();

        }



    }
}




