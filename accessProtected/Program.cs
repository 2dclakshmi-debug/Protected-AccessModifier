using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accessProtected
{
    class student
    {
        protected int id;
        public string name;
        public int age;
        public student(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            Console.WriteLine("Student id is :" + id);
            Console.WriteLine("Student name is :" + name);
            Console.WriteLine("Student age is :" + age);
        }
        
    }
    class student2:student
    {
        string course;
        public student2(int id,string name,int age,string course):base(id,name,age)
        {
            this.course = course;
            Console.WriteLine("Student Course : "+course);
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student id : ");
            int id=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter student name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter student age : ");
            int age = int.Parse(Console.ReadLine());

            student2 std = new student2(id,name,age,"CSC");
            
        }
    }
}
