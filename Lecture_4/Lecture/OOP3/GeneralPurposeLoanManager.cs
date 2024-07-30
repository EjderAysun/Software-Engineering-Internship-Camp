using System;

namespace Lecture_4.OOP3 {
    class GeneralPurposeLoanManager : ILoanManager {
        public void Calculate() {
            Console.WriteLine("General Purpose Loan payment is calculated.");
        }
    }
}