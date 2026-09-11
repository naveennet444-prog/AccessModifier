using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryLayer;


namespace AccessModifier
{
    internal class ClassA //project2 non-derived class.in project2 non-derived classes will access only public class members in project1.
    {
        public void Meth2()
        {
            Console.WriteLine("Accessing project1 base class in project2 non-derived class");
            Class1 obj1 = new Class1();
            Console.WriteLine(obj1.a);
            obj1.Pubmeth();
        }
    }
}
