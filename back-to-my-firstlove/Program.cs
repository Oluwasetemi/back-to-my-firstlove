using System;

namespace back_to_my_firstlove
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Oluwasetemi";
            Console.WriteLine("{0} {1}", name, 2 + 5);

            var temi = new Person();
            temi.Introduce();
            var total = Person.Add(10, 5.5);
            Console.WriteLine(total);
        }
    }

    
}
