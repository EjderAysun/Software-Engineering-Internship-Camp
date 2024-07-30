using System;

namespace Lecture_4.OOP3 {
    class HousingLoanManager : ILoanManager {
        public void Calculate() {
            Console.WriteLine("Housing Loan payment is calculated.");
        }
    }
}