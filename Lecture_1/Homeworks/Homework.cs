using System;

namespace Lecture_1.Homeworks {
    class Homework {
        public static void L1H1() {
            string question = "Question 1: What are the data types available in C#?";
            string answer = @"
            bool => true - false (2 bytes)
            byte => 0 to 255 (unsigned 8-bit integer)
            sbyte => -128 to 127 (signed 8-bit integer)
            char => U+0000 to U+FFFF (Unicode Basic Multilingual Character Set) (16 bit)
            decimal => +-1.0x10^(-28) to +-7.9228x10^28 (28-29 digits precision) (16 bytes)
            double => +-5.0x10^(-45) to +-1.7x10^308 (approximately 15-17 digits precision) (8 bytes)
            float => +-1.5x10^(-45) to +-3.4x10^38 (approximately 6-9 digits precision) (4 bytes)
            int => -2,147,483,648 to 2,147,483,647 (signed 32-bit integer)
            uint => 0 to 4,294,967,295 (unsigned 32-bit integer)
            nint => Depends on platform (computed at runtime) (signed 32-bit or 64-bit integer)
            nuint => Depends on platform (computed at runtime) (unsigned 32-bit or 64-bit integer)
            long => -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 (signed 64-bit integer)
            ulong => 0 to 18,446,744,073,709,551,615 (unsigned 64-bit integer)
            short => -32,768 to 32,767 (signed 16-bit integer)
            ushort => 0 to 65,535 (unsigned 16-bit integer)

            Reference: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types
            ";

            Console.WriteLine(question);
            Console.WriteLine(answer);
            Console.WriteLine("-----------------");
        }

        public static void L1H2() {
            string question = @"
            Research the 'ternary operator' in C#. 
            If you had to explain the Ternary Operator in writing to someone who doesn't know it,
            how would you explain it?
            ";
            string answer = @"
            When using ternary operator, the goal is assigning one of two values to a variable according to a condition.
            
            Structure:
            is this condition true ? yes : no
            
            Note: Look L1H2() method for the rest.
            ";

            Console.WriteLine(question);
            Console.WriteLine(answer);

            // Usage:
            int x = 5;
            int y = x > 6 ? 1 : 8; // y is 8
            y = x < 6 ? 1 : 8; // y is 1

            // Create Function via Ternary Operator
            //                                       condition ? consequent : alternative
            string GetGradeEvaluationTernaryOp(int grade) => grade < 70 ? "Bad" : "Perfect";
            Console.WriteLine("Grade Evaulation with Ternary Operator:");
            Console.WriteLine(GetGradeEvaluationTernaryOp(40)); // Output: Bad
            Console.WriteLine(GetGradeEvaluationTernaryOp(80)); // Output: Good
            // This struct is equals to this:
            string GetGradeEvaluationIfElse(int grade) {
                if(grade < 70) return "Bad";
                else return "Perfect";
            }
            Console.WriteLine("Grade Evaulation with If-Else Block:");
            Console.WriteLine(GetGradeEvaluationIfElse(40));
            Console.WriteLine(GetGradeEvaluationIfElse(80));
            // Using ternary operator instead of if-else blocks may be cause more short code but
            // sometimes ternary operator is more complex than if-else blocks.

            // Some Special Cases
            var rand = new Random();
            var condition = rand.NextDouble() > 0.5;
            // If target type of conditional expression is known,
            // the types of consequent and alternative must be implicitly convertible to the target type:
            int? a = condition ? 12 : null;

            IEnumerable<int> b = a is null ? new List<int>() { 0, 1 } : new int[] { 2, 3 };
            Console.WriteLine("Ternary Operator Special Case Results:");
            for(int i = 0; i < b.Count(); i++) { Console.WriteLine(b.ElementAt(i)); }

            // If a target type is unknown (for example 'var' keyword) or
            // the type of consequent and alternative must be the same or
            // there must be an implicit conversion from one type to another:
            var c = condition ? 12 : (int?)null;

            // The conditional operator is right-associative:
            // a ? b : c ? d : e
            // is evaluated as : a ? b : (c ? d : e)

            // A conditional ref expression conditionally returns a variable reference.
            // That means can be put a variable in consecutive and alternative fields,
            // and then the result is set equal to one of them.
            /*
            Structure:
            condition ? ref consequent : ref alternative
            */
            int z = 0, t = 0;
            (x > 6 ? ref z : ref t) = 100; // 100 value is assigned to t variable
            z = 0; t = 0;
            (x < 6 ? ref z : ref t) = 100; // 100 value is assigned to z variable

            /*
            For more detail and useful knowledges/tips:
            https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator
            */
            Console.WriteLine(); // For blank line
            Console.WriteLine("-----------------");
        }

        public static void L1H3() {
            string question = @"
            Research the 'switch' structure in C#.
            If you had to explain it in writing to someone who doesn't know the Switch structure,
            how would you explain it?
            ";
            string answer = @"
            When using switch-case the goal is to return a result according to a defined variable.
            The switch-case struct is very similar to the if-else struct in terms of one variable.
  
            Note: Look L1H3() method for the rest.
            ";

            Console.WriteLine(question);
            Console.WriteLine(answer);
            
            void GetGradeEvaluationSwitchCase(int grade) {
                switch(grade) {
                    case < 0:
                        Console.WriteLine("Invalid grade");
                        break;
                    case < 60:
                        Console.WriteLine("Bad grade");
                        break;
                    case < 75:
                        Console.WriteLine("Normal grade");
                        break;
                    case < 85:
                        Console.WriteLine("Good grade");
                        break;
                    case < 100:
                        Console.WriteLine("Perfect grade");
                        break;
                    case > 100:
                        Console.WriteLine("Invalid grade");
                        break;
                }
            }
            Console.WriteLine("Switch Case Results: ");
            GetGradeEvaluationSwitchCase(36);
            GetGradeEvaluationSwitchCase(78);
            GetGradeEvaluationSwitchCase(98);

            // You can specify multiple case patterns in one switch section:
            void GetGradeEvaluationSwitchCaseBetter(int grade) {
                switch(grade) {
                    case < 0:
                    case > 100:
                        Console.WriteLine("Invalid grade");
                        break;
                    case < 60:
                        Console.WriteLine("Bad grade");
                        break;
                    case < 75:
                        Console.WriteLine("Normal grade");
                        break;
                    case < 85:
                        Console.WriteLine("Good grade");
                        break;
                    case < 100:
                        Console.WriteLine("Perfect grade");
                        break;
                }
            }
            Console.WriteLine("Better Written Switch Case Results: ");
            GetGradeEvaluationSwitchCaseBetter(36);
            GetGradeEvaluationSwitchCaseBetter(78);
            GetGradeEvaluationSwitchCaseBetter(98);

            // Also there are case guards struct and switch case can be used with more than one defined variable.
            /*
            For more detail and useful knowledges/tips:
            https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements
            */
            Console.WriteLine();
            Console.WriteLine("-----------------");
        }

        public static void L1H4() {
            string question = @"
            Research the 'while loop' in C#.
            If you had to explain it in writing to someone who doesn't know the while loop,
            how would you explain it?
            ";
            string answer = @"
            When using a while loop the goal is to create infinite or conditional loop.

            For more detail and useful knowledges/tips:
            https://learn.microsoft.com/en-us/dotnet/visual-basic/language-reference/statements/while-end-while-statement
            ";

            Console.WriteLine(question);
            Console.WriteLine(answer);
            Console.WriteLine("-----------------");
        }            

        public static void L1H5() {
            string question = @"
            Write one quiz question.

            This question should include what we have learned so far.

            Do not indicate the correct answer.
            ";
            string answer = @"
            Quiz Questions:

            1- Write the below task using if-else, ternary operator, and switch case.
            Task: Create a method that has return type string, parameter type int and parameter name 'grade'.
            If the grade is significant,
            then this method returns the corresponding letter grade (AA, BA, BB, ..., FF);
            if the grade is not appropriate,
            then catch this inappropriate struct and warn the user by returning a warning statement.

            2- Iterate the below array and print its each element using for, foreach, and while loop.
            int[] arr = new int[]{1,2,3,4,5};

            Note: Look L1H5() method for the rest.
            ";

            Console.WriteLine(question);
            Console.WriteLine(answer);

            // Task 1 solution
            string ReturnLetterGradeWithIfElse(int grade) {
                if(grade >= 0 && grade < 50) return "FF";
                else if (grade >= 50 && grade < 60) return "FD";
                else if (grade >= 60 && grade < 65) return "DD";
                else if (grade >= 65 && grade < 70) return "DC";
                else if (grade >= 70 && grade < 75) return "CC";
                else if (grade >= 75 && grade < 80) return "CB";
                else if (grade >= 80 && grade < 85) return "BB";
                else if (grade >= 85 && grade < 90) return "BA";
                else if (grade >= 90 && grade <= 100) return "AA";
                else return "Invalid Grade";
            }
            string ReturnLetterGradeWithTernaryOp(int grade) {
                return (grade >= 0 && grade < 50) ? "FF" : (grade >= 50 && grade < 60 ? "FD" : (grade >= 60 && grade < 65 ? "DD" : (grade >= 65 && grade < 70 ? "DC" : (grade >= 70 && grade < 75 ? "CC" : (grade >= 75 && grade < 80 ? "CB" : (grade >= 80 && grade < 85 ? "BB" : (grade >= 85 && grade < 90 ? "BA" : (grade >= 90 && grade <= 100 ? "AA" : "Invalid Grade"))))))));
            }
            string ReturnLetterGradeWithSwitchCase(int grade) {
                switch (grade) {
                    case < 0:
                    case > 100:
                        return "Invalid grade";
                    case < 50:
                        return "FF";
                    case < 60:
                        return "FD";
                    case < 65:
                        return "DD";
                    case < 70:
                        return "DC";
                    case < 75:
                        return "CC";
                    case < 80:
                        return "CB";
                    case < 85:
                        return "BB";
                    case < 90:
                        return "BA";
                    case <= 100:
                        return "AA";
                }
            }
            Console.WriteLine("Task 1 Results:");
            Console.WriteLine("with if else: " + ReturnLetterGradeWithIfElse(73));
            Console.WriteLine("with ternary operator: " + ReturnLetterGradeWithTernaryOp(73));
            Console.WriteLine("with switch case: " + ReturnLetterGradeWithSwitchCase(73));

            // Task 2 solution
            int[] arr = new int[]{1,2,3,4,5};
            for(int i = 0; i < arr.Length; i++) {
                Console.WriteLine(arr[i]);
            }
            foreach (int item in arr) {
                Console.WriteLine(item);
            }
            int counter = 0;
            while(counter < arr.Length) {
                Console.WriteLine(arr[counter]);
                counter++;
            }
            Console.WriteLine();
            Console.WriteLine("-----------------");
        }

        public static void L1H6() {
            Product[] products = new Product[] {new Product("Banana", 2), new Product("Apple", 1), new Product("Strawberry", 4)};
        
            Console.WriteLine("With For Loop");
            for(int i = 0; i < products.Length; i++) {
                Console.WriteLine(products[i].productName + "==>" + products[i].productPrice);
            }
            Console.WriteLine("---");
            Console.WriteLine("With Foreach Loop");
            foreach (Product product in products) {
                Console.WriteLine(product.productName + "==>" + product.productPrice);
            }
            Console.WriteLine("---");
            Console.WriteLine("With While Loop");
            int counter = 0;
            while(counter < products.Length) {
                Console.WriteLine(products[counter].productName + "==>" + products[counter].productPrice);
                counter++;
            }
            Console.WriteLine("-----------------");
        }
    }

    // For HW 6
    class Product {
        public string productName {get;}
        public int productPrice {get;}
        public Product(string productName, int productPrice) {
            this.productName = productName;
            this.productPrice = productPrice;
        }
    }
}