using System;
 

namespace InheritanceDemo2
{
    class Sports : Student
    {
        string sportsName;
        protected int score;
        public Sports() : base() { }
        public Sports(int rn , string name, string batch, string sportsName, int score)
         : base ( rn , name , batch)
        {
            this.sportsName = sportsName;
            this.score = score;

        }
        public void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("Enter Sports Name");
            sportsName = Console.ReadLine();
            Console.WriteLine("Enter Score");
            score = Convert.ToByte(Console.ReadLine());
        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Sports Name " + sportsName);
            Console.WriteLine("Score is " + score);
        }

    }
}
