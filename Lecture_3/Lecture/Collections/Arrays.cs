using System;

namespace Lecture_3.Collections {
    class Arrays {
        public static void ArrayUsage() {
            string[] names = new string[] {"A", "B", "C", "D"};
            Console.WriteLine(names[0]); // A
            Console.WriteLine(names[1]); // B
            Console.WriteLine(names[2]); // C
            Console.WriteLine(names[3]); // D

            names = new string[5];
            names[4] = "E";
            Console.WriteLine(names[4]); // E
            Console.WriteLine(names[0]); // null, because
            // new array is holded in the heap, so this is reference type.
            // For that reason, the old array does not copying itself
            // instead of a new array is created.
        }
    }
}