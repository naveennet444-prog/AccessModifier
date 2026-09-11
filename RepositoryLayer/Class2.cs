using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public class Class2:Class1 //Project1 derived class.in same project derived classes will access all base class members of access modifiers expecct private.
    {
        public void Meth()
        {
            Console.WriteLine("Accessing project1 base class in project1 derived class");
            Class2 obj1 = new Class2();
            Console.WriteLine(obj1.a);
            Console.WriteLine(obj1.c);
            Console.WriteLine(obj1.d);
            Console.WriteLine(obj1.e);
            obj1.Pubmeth();
            obj1.Prometh();
            obj1.Intermeth();
            obj1.Prointermeth();
        }
    }
}
