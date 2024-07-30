using System;

namespace Lecture_3.OOP1 {
    class ProductManager {


        // CRUD (Create-Read-Update-Delete) Operations
        
        // Encapsulation
        public void Update(Product product) {
            Console.WriteLine(product.productName + " added.");
        }
        public void ChangeProductName(Product product) {
            product.productName = "Chair";
        }
        
        public void ChangeInt(int x) {
            x = 99;
        }
    }
}