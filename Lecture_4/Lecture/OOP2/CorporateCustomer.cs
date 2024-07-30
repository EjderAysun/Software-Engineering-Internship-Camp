using System;

namespace Lecture_4.OOP2 {
    class CorporateCustomer : Customer {
        public string companyName { get; set; }
        // consider that in this system the tax number
        // only belongs to the corporate customer
        public string taxNo { get; set; }
    }
}