using System;

namespace Lecture_1.Camp_Intro {
    class Class {
        public static void ClassExample () {
            Course course1 = new Course();
            course1.courseName = "C#";
            course1.instructor = "Ejder Aysun";
            course1.viewingRate = 68;

            Course course2 = new Course();
            course2.courseName = "C";
            course2.instructor = "Ejder Aysun";
            course2.viewingRate = 53 ;

            Course course3 = new Course();
            course3.courseName = "Python";
            course3.instructor = "A human";
            course3.viewingRate = 78 ;

            Course[] courses = new Course[]{course1, course2, course3};
            Console.WriteLine("Course : Instructor");
            foreach (Course course in courses) {
                Console.WriteLine(course.courseName + " : " + course.instructor);
            }
            Console.WriteLine("-----------------");
        }
    }

    class Course {
        public string courseName {get; set;}
        public string instructor {get; set;}
        public int viewingRate {get; set;}
    }

}