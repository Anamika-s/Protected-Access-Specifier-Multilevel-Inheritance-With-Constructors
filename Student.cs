using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo2
{
    class Student
    {
        int rn;
        string name;
        string batch;
        public Student() { }
        
        public Student(int rn , string name, string batch)
        {
            this.rn = rn;
            this.name = name;
            this.batch = batch;
        }
        public void GetDetails()
        {
            Console.WriteLine("Enter RollNo");
            rn = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Batch Code");
            batch = Console.ReadLine();
        }
        public void DisplayDetails()
        { 
            Console.WriteLine("RollNo is " + rn);
            Console.WriteLine("Name is " + name);
            Console.WriteLine("Batch Code is " + batch);
        }
    }
}
