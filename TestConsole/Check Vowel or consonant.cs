using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Check_Vowel_or_consonant
    {
        static void Main()
        {
            char c;
            bool isLowercaseVowel, isUppercaseVowel;
            Console.WriteLine("Enter an alphabet:");
            c = Convert.ToChar(Console.ReadLine());


            isLowercaseVowel = (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u');
            isUppercaseVowel = (c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U');
            if (isLowercaseVowel || isUppercaseVowel)
            {
                Console.WriteLine("{0}  is a vowel.", c);
            }
            else
            {
                Console.WriteLine("{0} is a consonant.", c);



            }


            Console.WriteLine("Enter an NOS:");

            int nos =Convert.ToInt32(Console.ReadLine());

           
            while(nos>=10)
            {


                nos = nos / 10;

            }
            Console.WriteLine("last digit of nos:{0}", nos);
            Console.ReadLine();
            Main();


        }

    }
}
