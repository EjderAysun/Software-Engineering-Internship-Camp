using System;
using Lecture_1.Camp_Intro;
using Lecture_1.Homeworks;

namespace Lecture_1 {
    class Program {
        public static void Main(string[] args) {
            // Camp Intro
            Fundamental.Intro();
            ArrayAndForeach.ArrayExample();
            Class.ClassExample();
            ForLoop.ForLoopExample();

            Console.WriteLine("HOMEWORKS");
            Console.WriteLine("-----------------");
            Homework.L1H1();
            Homework.L1H2();
            Homework.L1H3();
            Homework.L1H4();
            Homework.L1H5();
            Homework.L1H6();
        }
    }
}