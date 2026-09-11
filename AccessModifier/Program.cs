using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryLayer; //to access the class members in another project we need add that project to this project we need to add like using Projectname;

namespace AccessModifier
{
    public class Program : Class1 //project2 derived class.in project2 derived classes will access all base class members of project1 access modifiers expecct private and internal.

    {/* if we wnat to create multiple projects (or) Assembley's first we need to created a blank solution after we need to add new project like class librabry .Net framework (.dil).
        after we need to create another project like console application.now we need to link project 1 to project 2 first we need to build the project1 now we nedd 
        to click on open folder in file explorer after in bin we can see .dil file we need to copy address of that folder loacation.now in project2 references we need
        to click on add reference and in browse section we need to paste the copied folder address of .dll file.now we need to add project2 in namespaces like 
        using RepositoryLayer now we can access project1 in project 2.

     Access Modifiers :  Access specifiers are keywords which are specifying accessibility of a class or class members. 
           In C#.net we have 5 types of access specifiers 
                1) Public 
                2) Private 
                3) Protected 
                4) Internal 
                5) Protected Internal 
     - we can use access modifiers at class (in class only we can use Public and Internal,at variable declaration and method declaration.

    1) Public : If we declare a class or class member modifies as public which can be accessed by all the classes of current project, all the classes 
               of all the projects within that application

    2) Private : if we declare Class members as private we can use class members in same class only.creating class using private is not possible.
                 Among all the access modifiers private will provide more security.

    3) Protected : if we declare Class members as protected we can use class members in same class and derived class in same project and in derived class of another project as well.
                   .creating class unsing protected is not possible.

    4) Internal : If we declare a class or class member access modifier as internal this can be accessed by all the classes of the current project or assembly. 
                  if we create a class default access modifier of a class is internal.

    5) Protected Internal :  Protected Internal access modifier is combination Protected or Internal. if we declare Class members as protected Internal we can use class members 
                             in all classe's in same project and in derived class of another project.creating class using protected Internal is not possible.        */
        static void Main(string[] args)
        {
            Class2 obj1 = new Class2();
            obj1.Meth();
            Console.WriteLine();

            Class3 obj2 = new Class3();
            obj2.Meth1();
            Console.WriteLine();

            Console.WriteLine("Accessing project1 base class in project2 derived class");
            Program obj3 = new Program();
            Console.WriteLine(obj3.a);
            Console.WriteLine(obj3.c);
            Console.WriteLine(obj3.e);
            obj3.Pubmeth();
            obj3.Prometh();
            obj3.Prointermeth();
            Console.WriteLine();

            ClassA obj4 = new ClassA();
            obj4.Meth2();
            Console.ReadKey();
        }

    }
}
