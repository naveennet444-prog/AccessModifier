using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public class Class1 // Project1 base class.in same class we can access all access modifiers class members.
    {
        //Creating all types of access modifiers variables and methods
        public string a = "Public Access Variable in base class";
        private string b = "Private Access Variable in base class";
        protected string c = "Protected Access Variable in base class";
        internal string d = "internal Access Variable in base class";
        protected internal string e = "protected internal Variable in base class";

        public void Pubmeth()
        {
            Console.WriteLine("i am project1 base class public method");
        }
        private void Primeth()
        {
            Console.WriteLine("i am project1 base class private method");
        }
        protected void Prometh()
        {
            Console.WriteLine("i am project1 base class protected method");
        }
        internal void Intermeth()
        {
            Console.WriteLine("i am project1 base class internal method");
        }
        protected internal void Prointermeth()
        {
            Console.WriteLine("i am project1 base class protected internal method");
        }
    }
}
