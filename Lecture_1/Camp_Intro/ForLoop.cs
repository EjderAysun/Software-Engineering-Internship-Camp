using System;

namespace Lecture_1.Camp_Intro {
    class ForLoop {
        public static void ForLoopExample() {
            Console.WriteLine("For loop is started.");
            for(int i = 1; i <= 20; i++) {
                Console.WriteLine(i);
            }
            Console.WriteLine("For loop is over.");
            Console.WriteLine("---");
            Console.WriteLine("For loop is started.");
            for(int i = 1; i <= 20; i+=2) {
                Console.WriteLine(i);
            }
            Console.WriteLine("For loop is over.");
            Console.WriteLine("---");
            Console.WriteLine("For loop is started.");
            for(float i = 1; i <= 20; i+=2.23f) {
                Console.WriteLine(i);
            }
            Console.WriteLine("For loop is over.");
            Console.WriteLine("---");
            Console.WriteLine("For loop is started.");
            for(double i = 1; i <= 20; i+=2.32423) {
                Console.WriteLine(i);
            }
            Console.WriteLine("For loop is over.");
            Console.WriteLine("-----------------");
        }

    }
}