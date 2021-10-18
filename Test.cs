using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo2
{
    class Test : Sports
    {
        int[] marks = new int[5];
        int total=0;
        protected float per;
        public Test() : base() { }
        public Test(int rn , string name, string batch , string sportsName, int score, int[] marks)
       : base (rn, name, batch, sportsName, score)
        {
            for(int i=0;i<5;i++)
            {
                this.marks[i] = marks[i];
            }
            
        }
        public void GetDetails()
        {
            base.GetDetails();
          Console.WriteLine("Enter Marks ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Subject {0} ", i + 1);
                marks[i] = Convert.ToByte(Console.ReadLine());
                total = total + marks[i];
            }
            per = (float)total / 5;
        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Total Marks are " + total);
            Console.WriteLine("Per is "+ per); 
        }
    }
}
