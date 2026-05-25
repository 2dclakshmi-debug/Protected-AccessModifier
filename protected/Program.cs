using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @protected
{
    class student
    {
        protected int sid;
        protected string college;
        public student(int sid,string college)
        {
            this.sid = sid;
            this.college = college;
        }
        public void display()
        {
            Console.WriteLine("Student id : " + sid);
            Console.WriteLine("Student College : "+college);
        }
    }
    class student1:student
    {
        string sname;
        public student1(string sname):base(12,"raja")
        {
            this.sname=sname;
        }
        public void display1()
        {
            Console.WriteLine("Student name : "+sname);
            base.display();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           
            student1 s = new student1("Ravi");
            s.display1();
        }
    }
}
