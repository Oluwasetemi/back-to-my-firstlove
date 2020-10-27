﻿using System;
using System.Linq;

namespace back_to_my_firstlove
{
    // enums
    enum ShippingMethod
    {
        Regular = 1,
        Pro = 2,
        Amateur = 3
    }

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

            // working with Arrays
            var numbers = new int[3] { 1, 2, 3 };
            var names = new string[2] { "temi", "temidayo" };


            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            // working with String
            // String.format
            // String.Join
            Console.WriteLine("{0} weds {1}", names[0], names[1]);
            string together = string.Join("#", names);
            Console.WriteLine(together);
            Console.WriteLine(together[0]);
            // verbatim string @"content here"

            // using enum
            var method = ShippingMethod.Amateur;
            Console.WriteLine((int)method);
            Console.WriteLine((ShippingMethod)(int)method);
            Console.WriteLine(method.ToString());
            var result = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), "Amateur");
            Console.WriteLine(result);

            // Struc(value) - All primitive types  and classes(reference) - Array and String and Custom classes

            // conditional and loops
            // random class
        }

        public struct RgbColor
        {
            public int Red;
            public int Green;
            public int Blue;
        }
    }

    
}
