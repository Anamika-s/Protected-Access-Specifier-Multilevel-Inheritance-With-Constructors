using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo2
{
    class Result : Test
    {
        int finalResult;
        public Result() : base() { }
        public Result(int rn, string name, string batch, string sportsName, int score, int[] marks)
         : base(rn, name, batch, sportsName, score, marks)
        { }
            public void DisplayDetails()
        {
            base.DisplayDetails();
            finalResult = (int)per + score;
            Console.WriteLine("Final Score is " + finalResult);
        }
    }
}
