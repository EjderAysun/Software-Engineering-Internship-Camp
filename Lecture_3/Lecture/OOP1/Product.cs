using System;

namespace Lecture_3.OOP1 {

    // This type class has only attributes.
    class Product {  // Entity, etc.
        // primary key
        public int id { get; set; }
        // reference / foreign key
        public int categoryId { get; set; }
        public string productName { get; set; }
        public double unitPrice { get; set; }
        public int unitsInStock { get; set; }
    }
}