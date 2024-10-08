﻿namespace BankingManagementSystem. Infrastructure. Data. Constants
{
    public static class ValidationConstants
    {
        //General
        public const int IdNumberMaxLength = 10;


        //Customer
        public const int FirstNameMinLength = 2;
        public const int FirstNameMaxLength = 50;
        public const int MiddleNameMinLength = 2;
        public const int MiddleNameMaxLength = 50;
        public const int LastNameMinLength = 2;
        public const int LastNameMaxLength = 50;
        public const int AddressMinLength = 10;
        public const int AddressMaxLength = 300;
        public const int PhoneMaxLength = 10;
        public const int PhoneMinLength = 3;
        public const int PasswordMinLength = 6;
        public const int PasswordMaxLength = 100;
        public const int IdNumberMinLength = 10;


        //Account
        public const int AccountIbanMinLength = 15;
        public const int AccountIbanMaxLength = 34;
        public const int AccountNameMinLength = 4;
        public const int AccountNameMaxLength = 120;


        //Transaction
        public const int TransactionReasonMinLength = 5;
        public const int TransactionReasonMaxLength = 500;


        //Loan Application
        public const int LoanApplicationReasonMaxLength = 500;


        //Risk assessment
        public const int RiskAssessmentDetailsMaxLength = 300;
    }
}