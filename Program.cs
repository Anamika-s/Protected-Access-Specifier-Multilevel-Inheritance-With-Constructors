using System;

namespace InheritanceDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[] { 78, 90, 78, 96, 92 };
            Result result = new Result();
            result.GetDetails();
            result.DisplayDetails();
            NumericFunctions.Add(1, 2);
            NumericFunctions.IsEven(10);
            Result result1 = new Result(1, "Ajay", "B001", "Hockey", 19, marks);
            result.DisplayDetails();
        }
    }
}
