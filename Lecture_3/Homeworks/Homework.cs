using System.Runtime.CompilerServices;
using Lecture_3.GenericsIntro;
using Microsoft.VisualBasic;

namespace Lecture_3.Homeworks {
    class Homework {
        public static void L3H1() {
            // int, decimal, float, enum, boolean value types
            int number1 = 10;
            int number2 = 20;

            number1 = number2;
            number2 = 100;
            Console.WriteLine("number1: " + number1); // number1 is 20 because number2 is passed as a value
        
            // arrays, class, interface... reference types
            int[] numbers1 = new int[] {1,2,3};
            int[] numbers2 = new int[] {10, 20, 30};

            numbers1 = numbers2;
            numbers2[0] = 1000;

            Console.WriteLine("numbers1[0] = " + numbers1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.firstName = "Ejder";
            person2 = person1;
            person1.firstName = "Hasan";

            Console.WriteLine("person2 firstName: " + person2.firstName); // person2's firstName is 'Hasan' because person1 is passed as a reference

            Customer customer1 = new Customer();
            customer1.creditCardNumber = "123456789";
            customer1.firstName = "Mehmet";
            
            Employee employee1 = new Employee();

            Person person3 = customer1;
            Console.WriteLine("person3 firstName: " + person3.firstName);
            // wrong usage:
            // Console.WriteLine(person3.creditCardNumber);
            // correct usage:
            Console.WriteLine("person3 credit card number: " + ((Customer)person3).creditCardNumber);

            Employee employee2 = new Employee();
            employee2.firstName = "Employee Name";
            Customer customer2 = new Customer();
            customer2.firstName = "Customer Name";
            Person person4 = new Person();
            person4.firstName = "Person Name";

            PersonManager personManager = new PersonManager();
            // go to the Add() method and check
            personManager.Add(employee2);
            personManager.Add(customer2);
            personManager.Add(person4);
        }

        public static void L3H2() {
            // usage 1
            Customer customer1 = new Customer();

            // usage 2              the paranthesis is not necessary, default constructor
            Customer customer2 = new Customer() {id=1, firstName = "Ejder", lastName = "Aysun", city = "Ankara"};
            Console.WriteLine("Customer id: " + customer2.id);
            Console.WriteLine("Customer first name: " + customer2.firstName);
            Console.WriteLine("Customer last name: " + customer2.lastName);
            Console.WriteLine("Customer city: " + customer2.city);
        }

        public static void L3H3() {
            MyList<string> myList = new MyList<string>();
            Console.WriteLine(myList.Count); // 0
            myList.Add("any string");
            Console.WriteLine(myList.Count); // 1
            // myList.Add(2); // error
        }

        public static void L3H4() {
            // How would you explain the dictionary structure to someone who doesn't know it?
            /*
            The dictionary structure is just like a real-world dictionary. It contains data that will have a value and its value.
            In this context, the data that will have value is called a key (we can think of it as unlocking the value) and the key's equivalent is called a value.
            A key can only exist once in a dictionary, but a value can correspond to more than one key.
            We can think of it like this; two different keys can open the same door, but one key can only open one door. In this case the door is the value.
            */
            Dictionary<string, string> myDict1 = new Dictionary<string, string>();
            myDict1.Add("any string for key", "any string for value");
            // or
            Dictionary<string, int> myDict2 = new Dictionary<string, int>();
            myDict2.Add("any string for key", 3);
            // or
            Dictionary<int, string> myDict3 = new Dictionary<int, string>();
            myDict3.Add(3, "any string for value");
            // or
            Dictionary<int, int> myDict4 = new Dictionary<int, int>();
            myDict4.Add(3, 56);
            // or
            // ...
        }

        public static void L3H5() {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            Console.WriteLine(myDictionary.Count); // 0
            myDictionary.Add("any string", 143);
            Console.WriteLine(myDictionary.Count); // 1
            // myDictionary.Add("any string", "any string"); // error
            // myDictionary.Add(126, 143); // error
        }
    }
}