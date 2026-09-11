using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public class Class3 //project1 non-derived class.in same project non-derived classes will access all base class members of access modifiers expecct private and protected.
    {
        public void Meth1()
        {
            Console.WriteLine("Accessing project1 base class in project1 non-derived class");
            Class1 obj1 = new Class1();
            Console.WriteLine(obj1.a);
            Console.WriteLine(obj1.d);
            Console.WriteLine(obj1.e);
            obj1.Pubmeth();
            obj1.Intermeth();
            obj1.Prointermeth();
        }
    }
}
