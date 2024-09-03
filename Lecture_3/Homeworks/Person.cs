namespace Lecture_3.Homeworks {
    public class Person {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }

    // base class : Person
    class Customer : Person {
        // default constructor, for usage 1
        public Customer() {
            
        }

        // for usage 2
        public Customer(int id, String firstName, String lastName, String city) {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.city = city;
            Console.WriteLine("Constructor block worked");
        }
        
        public string creditCardNumber { get; set; }
        public String city { get; set; }
    }

    // base class : Person
    class Employee : Person {
        public int employeeNumber { get; set; }
    }

    class PersonManager {
        public void Add(Person person) {
            Console.WriteLine(person.firstName);
        }
    }
}