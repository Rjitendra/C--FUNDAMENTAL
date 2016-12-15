using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class concatletter
    {
        public static void Main()
        {
            Console.WriteLine("enter str1");
            string str1 = Console.ReadLine();
            Console.WriteLine("enter str2");
            string str2 = Console.ReadLine();
            char[] array1 = str1.ToCharArray();
            char[] array2 = str2.ToCharArray();
            ArrayList list = new ArrayList();
            StringBuilder sbr = new StringBuilder();

            int arrlength = array1.Length >= array2.Length ? array2.Length : array1.Length;
            for (int i = 0; i <arrlength; i++)
            {
                

                    string res = array1[i].ToString()+array2[i].ToString();
                list.Add(res);
                
            }
                
                
            
            
            for(int i=0;i<list.Count;i++)
            {
            Console.WriteLine(list[i].ToString());
            
            }

            Console.ReadLine();
            
            }
        
        
        
        }
    }

