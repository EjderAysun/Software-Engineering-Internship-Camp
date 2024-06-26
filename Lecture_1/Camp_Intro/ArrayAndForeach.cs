using System;

namespace Lecture_1.Camp_Intro {
    public class ArrayAndForeach {
        public static void ArrayExample() {
            string course1 = "C# Camp";
            string course2 = "Computational Physics Course";
            string course3 = "Data Structures and Algorithms Course";

            // array
            string[] courses = new string[] {course1, course2, course3};

            Console.WriteLine("For loop is started.");
            for(int i = 0; i < courses.Length; i++) {
                Console.WriteLine(i);
            }
            Console.WriteLine("For loop is over.");
            Console.WriteLine("---");
            Console.WriteLine("For loop is started.");
            Console.WriteLine("Courses:");

            // foreach
            foreach (string course in courses) {
                Console.WriteLine(course);
            }

            Console.WriteLine("For loop is over.");
            Console.WriteLine("---");
            Console.WriteLine("footer");
            Console.WriteLine("-----------------");
        }
    }
}