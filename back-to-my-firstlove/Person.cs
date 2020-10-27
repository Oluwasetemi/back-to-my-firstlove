using System;
namespace back_to_my_firstlove
{
    public class Person
    {
        public string Name;

        public void Introduce()
        {
            Name = "oluwasetemi";
            Console.WriteLine("Hi, my name is {0}", Name);
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }
    }
}
