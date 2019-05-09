using System;

namespace DayOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] myArr = new int[] {1,2,3,4,5};
            Console.WriteLine(myArr);
            for(int i=0;i<myArr.Length;i++)
            {
                System.Console.WriteLine(myArr[i]*8);
            }
            Test test = new Test();
            test.SayHi();
        }
    }
}
