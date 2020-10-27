using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

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

            // random class
            var PI = 3.14f;
            var random = new Random();
            Console.WriteLine(random.Next(1, 10));

            var buffer = new char[10];
            for (int i = 0; i < 10; i++)
                buffer[i] = (char)('a' + random.Next(0, 26));
            

            var password = new string(buffer);

            Console.WriteLine(password);

            // Array and List
            Console.WriteLine("working with Array and List");
            Console.WriteLine("working with Array");
            Console.WriteLine();
            // declare array - single, rectangular and jagged
            var single = new[] { 2, 3, 4, 5 };
            var rectA = new int[3, 3]
            {
                { 1, 2, 3},
                { 4, 5, 6},
                { 7, 8, 8},
            };

            var jagged = new int[3][];
            jagged[0] = new int[2] { 1, 2 };
            jagged[1] = new int[3] { 1, 2, 3 };
            jagged[2] = new int[4] { 1, 2, 3, 0 };


            // propeties and method
            // lenght
            Console.WriteLine("Length: {0}", single.Length);
            // indexOf
            Console.WriteLine("Index of 3 in single {0}",Array.IndexOf(single, 3));
            // clear
            Array.Clear(single, 2, 1);
            Console.WriteLine("Print array Clear result");
            foreach (var i in single)
            {
                Console.WriteLine(i);
            }
            // copy
            var clone = new int[4];
            Array.Copy(single, clone, 4);
            Console.WriteLine("Print array Copy result");
            foreach (var i in clone)
            {
                Console.WriteLine(i);
            }
            // sort
            Console.WriteLine("Print array Sort result");
            Array.Sort(clone);
            //Array.Sort(single);
            foreach (var i in clone)
            {
                Console.WriteLine(i);
            }
            // reverse
            Array.Reverse(clone);
            Console.WriteLine("Print array Reverse result");
            foreach (var i in clone)
            {
                Console.WriteLine(i);
            }
            // static methods, instance.methods
            var sum = single.Sum();
            Console.WriteLine("Sum of single array - {0}", sum);

            // List
            Console.WriteLine("working with List");
            // declaration
            var scores = new List<int>() { 1, 2, 3, 4 };
            Console.WriteLine();
            Console.WriteLine("Print  List");
            foreach (var i in scores)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            // Add
            scores.Add(2);
            // AddRange
            scores.AddRange(new int[] { 5, 6, 7 });
            Console.WriteLine();
            Console.WriteLine("Print  List after adding 2 and range(5, 6, 7)");
            foreach (var i in scores)
            {
                Console.WriteLine(i);
            }
            // IndexOf
            var indexOf4 = scores.IndexOf(4);
            Console.WriteLine("Index of 4: {0}", indexOf4);
            // LastIndexof
            var lastIndexOf4 = scores.IndexOf(4);
            Console.WriteLine("LastIndex of 4: {0}", lastIndexOf4);
            // Count
            Console.WriteLine(scores.Count);
            // Remove
            Console.WriteLine();
            Console.WriteLine("Print  scores");
            foreach (var i in scores)
            {
                Console.WriteLine(i);
            }
            //scores.Remove(2);
            // AddRange
            //scores.RemoveRange(new int[] { 5, 6, 7 });
            Console.WriteLine();
            for (int i = 0; i < scores.Count; i++)
            {
                if (scores[i] == 2)
                {
                    Console.WriteLine("removing 2");
                    scores.Remove(scores[i]);
                }
            }
            // Remove mutiple with loop
            Console.WriteLine("Print  the new List after removing all 2");
            foreach (var i in scores)
            {
                Console.WriteLine(i);
            }
            // RemoveAt
            scores.RemoveAt(scores.Count - 1);
            Console.WriteLine("Print scores after remove the last element in the list");
            foreach (var i in scores)
            {
                Console.WriteLine(i);
            }
            // Clear
            scores.Clear();
            Console.WriteLine("Cleared");
            foreach (var i in scores)
            {
                Console.WriteLine(i);
            }

            // working with dates

            // working with text

            // working with Files

            // debugging applications





            // Struc(value) - All primitive types  and classes(reference) - Array and String and Custom classes

            // conditional and loops
            while (true)
            {
                Console.WriteLine("What is your name?");
                var input = Console.ReadLine();
                Console.WriteLine(string.Format("@Echo: {0}", input));
                if (String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("The END");
                    break;
                }

            }


           
        }

        public struct RgbColor
        {
            public int Red;
            public int Green;
            public int Blue;
        }
    }

    
}
