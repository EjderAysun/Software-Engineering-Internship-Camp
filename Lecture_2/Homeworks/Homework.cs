using System;

namespace Lecture_2.Homeworks {
    class Homework {
        public static void L2H1() {
            void Add1() {
                Console.WriteLine("Added!");
            }
            int Add2(int num1, int num2) {
                return num1+num2;
            }

            // Default params must be at the end of the param sequence.
            // Because if default param is first, then method does not
            // understand if it should override the default parameter.
                                // default param
            int Add3(int num1, int num2 = 30) {
                return num1+num2;
            }

            int Add4(int num1, int num2) {
                num1 = 30;  
                return num1+num2;
            }

            int Add5(ref int num1, int num2) {
                num1 = 30;  
                return num1+num2;
            }

            int Add6(out int num1, int num2) {
                num1 = 30;  
                return num1+num2;
            }
            
            Console.WriteLine("Add1 method");
            Add1();
            // -------------
            Console.WriteLine("Add2 method result: " + Add2(5, 10));
            // -------------
            // Wrong usage for Add3 method
            // Console.Writeline(Add3());

            // Correct usages for Add3 method
            Console.WriteLine("Add3 method result: " + Add3(5));
            Console.WriteLine(Add3(5, 10));
            // -------------
            int num1 = 20;
            int num2 = 30;
            Console.WriteLine("Add4 method result: " + Add4(num1, num2));
            Console.WriteLine("num1 after over the method and assigning 30 to the num1: " + num1);
            string explanation1 = @"
                At the beginning of the process, the num1 is 20. In the Add4 method, the 30 is assigned to the
                num1. The calculation is made using this assigning. After over the method, num1 is 20.
                Because num1 is passed as a value.
            ";
            Console.WriteLine(explanation1);
            // -------------
            Console.WriteLine("'REF' KEYWORD");
            int num3 = 20;
            int num4 = 30;                          // note here, we must use ref keyword while placing the value as a parameter
            Console.WriteLine("Add5 method result: " + Add5(ref num3, num4));
            Console.WriteLine("num3 after over the method and assigning 30 to the num3: " + num3);
            string explanation2 = @"
                At the beginning of the process, the num3 is 20. In the Add5 method, the 30 is assigned to the
                num3. The calculation is made using this assigning. After over the method, num3 is 30.
                When we use 'ref' keyword, the parameter is passed as a reference, not a value.
                For that reason, num3 is passed as a reference.
            ";
            Console.WriteLine(explanation2);
            // -------------
            Console.WriteLine("'OUT' KEYWORD");
            int num5;
            int num6 = 30;                          // note here, we must use out keyword while placing the value as a parameter
            Console.WriteLine("Add5 method result: " + Add6(out num5, num6));
            Console.WriteLine("num5 after over the method and assigning 30 to the num5: " + num5);
            string explanation3 = @"
                At the beginning of the process no value assigned to the num5. In the Add6 method, the
                30 is assigned to the num5.
                The calculation is made using this assigning. After over the method, num5 is 30.
                When we use 'out' keyword, the parameter is passed as a reference, not a value.
                For that reason, num5 is passed as a reference.
                Only difference between 'out' and 'ref' keyword is when 'out' keyword is used must be
                assigned a value to the variable which is the parameter in the method and may or may not be
                assigned a value to the it in out of method, but when 'ref' keyword is used the must be
                assigned a value to the variable which is the parameter in out of method
                and may or may not be set a value to the variable in the method.
            ";
            Console.WriteLine(explanation3);
            // -------------      
            Console.WriteLine("Method Overloading");
            Console.WriteLine(Multiply(3,5));
            Console.WriteLine(Multiply(3,5,6));
            Console.WriteLine(Multiply(3,5,6,9));
            string explanation4 = @"
                We can increase or decrease parameter numbers, change the return type or change the parameter type of
                a method and create new one with the same name. This is method overloading.
            ";
            Console.WriteLine(explanation4);
            // -------------  
            Console.WriteLine("'Params' keyword usage");    
            int MultiplyWithParams(params int[] nums) {
                int result = 1;
                foreach (int num in nums) {
                    result *= num;
                }
                return result;
            }
            // wrong usage
            /*
            int MultiplyWithParams(int num, params int[] nums) {
                int result = num;
                foreach (int num in nums) {
                    result *= num;
                }
                return result;
            }
            */
            string explanation5 = @"
                'params' keyword is used for when we must use unknown number of parameters.
            ";
            Console.WriteLine(MultiplyWithParams(1,3,5,8,2));
            Console.WriteLine(explanation5);
        }
    //s  i  g  n    o  f    m  e  t  h  o  d
        static int Multiply(int num1, int num2) {
            return num1*num2;
        }
        // Method overloading
        static int Multiply(int num1, int num2, int num3) {
            return num1*num2*num3;
        }
        static double Multiply(double num1, int num2, float num3, int num4) {
            return num1*num2*num3*num4;
        }
        public static void L2H2() {
            string question = "Question 2: How would you explain to someone who doesn't know the keywords ref and out?";
            string answer = @"
                The 'ref' keyword is used for using a value type as a reference type in a method.
                The 'out' keyword is used with the same logic, but there is one difference.
                Only difference between 'out' and 'ref' keyword is when 'out' keyword is used must be
                assigned a value to the variable which is the parameter in the method and may or may not be
                assigned a value to the it in out of method, but when 'ref' keyword is used the must be
                assigned a value to the variable which is the parameter in out of method
                and may or may not be set a value to the variable in the method.
            ";
            Console.WriteLine(question);
            Console.WriteLine(answer);
        }
        public static void L2H3() {
            Customer c1 = new Customer("1", "A", "B");
            Customer c2 = new Customer("2", "C", "D");
            Customer c3 = new Customer("3", "E", "F");
            Customer c4 = new Customer("4", "G", "H");
            Customer c5 = new Customer("5", "J", "K");

            CustomerManager customerManager = new CustomerManager();
            customerManager.AddCustomer(c1);
            customerManager.AddCustomer(c2);
            customerManager.AddCustomer(c3);
            customerManager.AddCustomer(c4);
            customerManager.AddCustomer(c5);

            Console.WriteLine("All Customers");
            customerManager.PrintCustomers();

            customerManager.RemoveCustomer(c3);
            
            Console.WriteLine("After Deleting Customer 3");
            customerManager.PrintCustomers();
        }
    }
}