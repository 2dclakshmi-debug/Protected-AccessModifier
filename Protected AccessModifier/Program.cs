using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected_AccessModifier
{
    class MyClass
    {
        protected string Name;
        public MyClass(string name)
        {
            Name = name;
            Console.WriteLine("Name is :" + Name);
        }
    }
    class NewClass:MyClass
    {
        public NewClass(string name):base(name)
        {
            Name = name;
            Console.WriteLine("Name is :"+Name);
        }
    }
   
    internal class Program:NewClass
    {
        public Program(string name) : base(name)
        {
            Name = name;
            Console.WriteLine("Name is :" + Name);
        }
        static void Main(string[] args)
        {
            Program obj = new Program("Rani");
        }
    }
}
