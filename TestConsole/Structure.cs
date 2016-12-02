using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class jitu
    {
        public static void Main(string[] args)
        {


            Structure obj = new Structure();//when you create with new keyword you can acces the method,fiels of structure.
            Structure obj1;//when you create without new keyword you can acces the fiels only of structure.
            obj.x = 5;
            obj1.x = 15;
            obj.display();
            obj1.display();
            string para = "Well come jitendra";
            Structure obj2 = new Structure(5, para);//Declare constructure with parameter.

     
            Console.ReadKey();
        }

    }


    struct Structure
    {
        public int x;
        public void display() { Console.WriteLine("Jitendra value is {0}", this.x); }
        //public void jitu(string Parameter) { Console.WriteLine("{0}", Parameter); }

        public Structure(int x, string para)
        {
            this.x = x;
            Console.WriteLine("constructor use in structure-{0},{1}",x,para);

        }
    }


}


//try as list


//Class versus Structure
//=========================
//Classes and Structures have the following basic differences:

//classes are reference types and structs are value types

//structures do not support inheritance

//structures cannot have default constructor

//Features of C# Structures
//============================
//You have already used a simple structure named Books. Structures in C# are quite different from that in traditional C or C++. The C# structures have the following features:

//Structures can have methods, fields, indexers, properties, operator methods, and events.

//Structures can have defined constructors, but not destructors. However, you cannot define a default constructor for a structure. The default constructor is automatically defined and cannot be changed.

//Unlike classes, structures cannot inherit other structures or classes.

//Structures cannot be used as a base for other structures or classes.

//A structure can implement one or more interfaces.

//Structure members cannot be specified as abstract, virtual, or protected.

//When you create a struct object using the New operator, it gets created and the appropriate constructor is called. Unlike classes, structs can be instantiated without using the New operator.

//If the New operator is not used, the fields remain unassigned and the object cannot be used until all the fields are initialized.