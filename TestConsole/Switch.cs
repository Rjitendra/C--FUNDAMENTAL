using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Test
    {
        int i = 5;
        public void dispaly(string no)
        {
            int Nos = Convert.ToInt32(no);
            switch (Nos)
            {

                case 5:
                    Console.WriteLine("Value of x is 5");
                    break;
                case 10:
                    Console.WriteLine("Value of x is 10");

                    break;
                case 15:
                    Console.WriteLine("Value of x is 15");
                    break;
                default:
                    Console.WriteLine("Unknown value");
                    break;


            }
        }

   public static void Main()
        {
            Console.WriteLine("Enter a no");
            string no = Console.ReadLine();

            Test Obj = new Test();
            Obj.dispaly(no);
            Console.ReadKey();
          

        


    }
}}
