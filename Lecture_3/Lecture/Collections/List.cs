using System;

namespace Lecture_3.Collections {
    class List {
        public static void ListUsage() {
            // A new element cannot be added or removed from an array, so we use a list.
            List<string> names = new List<string> {"A", "B", "C", "D"};
            Console.WriteLine(names[0]); // A
            Console.WriteLine(names[1]); // B
            Console.WriteLine(names[2]); // C
            Console.WriteLine(names[3]); // D
            names.Add("E");
            Console.WriteLine(names[4]); // E
            Console.WriteLine(names[0]); // A
        }
    }
}