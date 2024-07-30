using System;
using System.Reflection.Metadata.Ecma335;
using Lecture_4.OOP2;
using Lecture_4.OOP3;

namespace Lecture_4 {
    class Program {
        static void Main(string[] args) {
            // OOP2
            // Ejder Aysun => Individual Customer
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.id = 1;
            customer1.customerNo = "12345";
            customer1.name = "Ejder";
            customer1.surname = "Aysun";
            customer1.tcNo = "12345678910";

            // ejder.com => Corporate Customer
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.id = 2;
            customer2.customerNo = "54321";
            customer2.companyName = "ejder.com";
            customer2.taxNo = "1234567890";

            // there are individual customer and corporate customer
            // SOLID
            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);

            // OOP3
            GeneralPurposeLoanManager generalPurposeLoanManager1 = new GeneralPurposeLoanManager();
            // generalPurposeLoanManager1.Calculate();
            // The interface can hold the reference of the class that implements it.
            ILoanManager generalPurposeLoanManager2 = new GeneralPurposeLoanManager();
            // generalPurposeLoanManager2.Calculate();

            VehicleLoanManager vehicleLoanManager1 = new VehicleLoanManager();
            // vehicleLoanManager1.Calculate();
            // The interface can hold the reference of the class that implements it.
            ILoanManager vehicleLoanManager2 = new VehicleLoanManager();
            // vehicleLoanManager2.Calculate();

            HousingLoanManager housingLoanManager1 = new HousingLoanManager();
            // housingLoanManager1.Calculate();
            // The interface can hold the reference of the class that implements it.
            HousingLoanManager housingLoanManager2 = new HousingLoanManager();
            // housingLoanManager2.Calculate();

            LoanApplicationManager loanApplicationManager = new LoanApplicationManager();
            List<ILoggerService> databaseLoggerService = new List<ILoggerService> {new DatabaseLoggerService(), new FileLoggerService()};
            List<ILoggerService> fileLoggerService = new List<ILoggerService>() {new FileLoggerService()};
                                                                            // use this
            loanApplicationManager.ApplyForLoan(generalPurposeLoanManager1, new List<ILoggerService>() {new DatabaseLoggerService()});
                                                                     // or this
            loanApplicationManager.ApplyForLoan(vehicleLoanManager1, databaseLoggerService);
            loanApplicationManager.ApplyForLoan(housingLoanManager1, fileLoggerService);
            // or for collective usage:
            List<ILoggerService> loggerServices = new List<ILoggerService>(){new DatabaseLoggerService(), new FileLoggerService()};
            loanApplicationManager.ApplyForLoan(vehicleLoanManager1, loggerServices);
            loanApplicationManager.ApplyForLoan(housingLoanManager1, loggerServices);

            List<ILoanManager> loans = new List<ILoanManager>() {generalPurposeLoanManager1, vehicleLoanManager1};
            loanApplicationManager.ProvideLoanPreNotification(loans);
        }
    }
}