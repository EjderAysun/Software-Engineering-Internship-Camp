using System;
using Lecture_3.OOP1;
using Lecture_3.Collections;
using Lecture_3.GenericsIntro;

namespace Lecture_3 {
    class Program {
        static void Main(string[] args) {
            // OOP 1
            Product product1 = new Product();
            product1.id = 1;
            product1.categoryId = 2; // 2 represents furnitures
            product1.productName = "Table";
            product1.unitPrice = 500;
            product1.unitsInStock = 3;

            Product product2 = new Product{id=2, categoryId=5,  // 5 represents stationery
            unitsInStock = 10, productName = "Pencil", unitPrice = 35};

            // C# is case sensitive.
            // PascalCase  // camelCase
            ProductManager productManager = new ProductManager();
            //         STACK                        HEAP

            //------------------------
            // REFERENCE - VALUE TYPE TEST            
            productManager.ChangeProductName(product1);
            Console.WriteLine("After product1's name changing as 'Chair' in the ProductManager Class' ChangeProductName() method: " + product1.productName);  // passed as a reference, the result is 'Chair'

            int x = 100;
            productManager.ChangeInt(x);
            Console.WriteLine("After x's value changing as 99 in the ProductManager Class' ChangeInt() method: " + x);  // passed as a value, the result is 100
            //------------------------
            // int, double, bool... => value type
            // arrays, classes, abstract classes, interface... => reference type

            // Please look into these methods.
            Arrays.ArrayUsage();
            List.ListUsage();

            MyList<string> myList = new MyList<string>();
        } 
    }
}