using System;
using System.Collections;

namespace Lecture_2.Homeworks {

    class Customer {
        public string id {get; set;}
        public string name {get; set;}
        public string surname {get; set;}
        
        // Constructor 
        public Customer(string id, string name, string surname) {
            this.id = id;
            this.name = name;
            this.surname = surname;
        }
    }

    class CustomerManager {
        List<Customer> customers = new List<Customer>();

        public void AddCustomer(Customer c) {
            customers.Add(c);
        }

        public void RemoveCustomer(Customer c) {
            if(customers.Contains(c)) {
                customers.Remove(c);
            } else {
                Console.WriteLine("This customer is not on the list.");
            }
        }

        public void PrintCustomers() {
            foreach (Customer c in customers) {
                Console.WriteLine(c.name);
            }
        }
    }
}