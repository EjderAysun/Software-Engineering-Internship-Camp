using System;
using Lecture_2.Methods;
using Lecture_2.ValueAndReferenceTypes;
using Lecture_2.Homeworks;

namespace Lecture_2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("-------------METHODS--------------");
            // instance
            BasketManager basketManager = new BasketManager();

            Product product1 = new Product();
            product1.name = "banana";
            product1.price = 2;
            product1.explanation = "Cavendish";

            Product product2 = new Product();
            product2.name = "pineapple";
            product2.price = 4;
            product2.explanation = "Smooth Cayenne";

            // encapsulation
            basketManager.Add(product1);
            basketManager.Add(product2);
            
            Console.WriteLine();
            Console.WriteLine("Value Type");
            Types.ValueType();
            Console.WriteLine();
            Console.WriteLine("Reference Type");
            Types.ReferenceType();
            
            Console.WriteLine();
            Console.WriteLine("HOMEWORKS");
            Console.WriteLine("-----------------");
            Homework.L2H1();
            Homework.L2H2();
            Homework.L2H3();
        }
    }
}