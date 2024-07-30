using System;

namespace Lecture_4.OOP3 {
    class LoanApplicationManager {
        // Evaluating applicant information
        // Now the application is credit-independent.
                                                           // Method Injection
        public void ApplyForLoan(ILoanManager loanManager, List<ILoggerService> loggerServices) {
            loanManager.Calculate();
            foreach(ILoggerService loggerService in loggerServices) {
                loggerService.Log();
            }
        }

        // Method Injection
        public void ProvideLoanPreNotification(List<ILoanManager> loans) {
            foreach(ILoanManager loanManager in loans) {
                loanManager.Calculate();
            }
        }
    }
}