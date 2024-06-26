using System;

namespace Lecture_1.Camp_Intro {
    class Fundamental {
        public static void Intro() {
            // type safety
			// do not repeat yourself (importance of functions)
			
            string categoryTag = "Category";
            int studentNum = 32000;
            double interestRate = 1.45;
            bool enteredTheSystem = false;
			double dollarYesterdayVal = 30.45;
			double dollarTodayVal = 30.65;

			if(dollarYesterdayVal > dollarTodayVal) {
				Console.WriteLine("Decrease button");
			} else if (dollarYesterdayVal < dollarTodayVal) {
				Console.WriteLine("Increse button");
			} else {
				Console.WriteLine("No Change button");
			}

			if(enteredTheSystem == true) {
				Console.WriteLine("User Settings button");
			}else {
				Console.WriteLine("Login button");
			}

			Console.WriteLine(categoryTag);
			Console.WriteLine("-----------------");
		}
    }
}