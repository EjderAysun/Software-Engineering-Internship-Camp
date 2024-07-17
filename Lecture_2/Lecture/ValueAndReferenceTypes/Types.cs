using System;

namespace Lecture_2.ValueAndReferenceTypes {
    class Types {
        public static void ValueType() {
            // VALUE TYPES
            /*
            - Integral numeric types
            - Floating-point numeric types
            - bool that represents a Boolean value
            - char that represents a Unicode UTF-16 character

            For more detailed information visit here:
            https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types
            */

            int x = 10;
            int y = 20;
            x = y;
            y = 30;
            // What is x?
            // x is 30
            string result = @"
                int x = 10;
                int y = 20;
                x = y;
                y = 30;
                What is x?
            ";

            string process = @"
                Before:
                stack       heap
                101/x       101/10
                102/y       102/20

                Process:
                stack       heap
                101/x       101/20
                102/y       102/20

                After:
                stack       heap
                101/x       101/20 (x is 20)
                102/y       102/30
            ";
            Console.WriteLine(result);
            Console.WriteLine(process);
            Console.WriteLine("x is " + x + " because x is a value type");
        }

        public static void ReferenceType() {
            //REFERENCE TYPES
            /*
            The following keywords are used to declare reference types:
            - class
            - interface
            - delegate
            - record
            
            C# also provides the following built-in reference types:
            - dynamic
            - object
            - string

            For more detailed information visit here:
            https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/reference-types
            */

            int[] numbers1 = new int[] { 10, 20, 30 };
            int[] numbers2 = new int[] { 100, 200, 300 };
            numbers1 = numbers2;
            numbers2[0] = 999;
            // What is numbers1[0]?
            // numbers1[0] is 999

            string result = @"
                int[] numbers1 = new int[] { 10, 20, 30 };
                int[] numbers2 = new int[] { 100, 200, 300 };
                numbers1 = numbers2;
                numbers2[0] = 999;

                What is numbers1[0]?
                numbers1[0] is 999
            ";

            string process = @"
                Before:
                stack           heap
                101/numbers1    101/[10,20,30]
                102/numbers2    102/[100,200,300]

                Process:
                stack           heap
                102/numbers1    101/[10,20,30] (garbage collector)
                102/numbers2    102/[100,200,300]

                After:
                stack           heap
                102/numbers1    
                102/numbers2    102/[999,200,300] (numbers1[0] is 999)
            ";
            Console.WriteLine(result);
            Console.WriteLine(process);
            Console.WriteLine("numbers1 is " + numbers1[0] + " because numbers1 is a reference type");
        }
    }
}