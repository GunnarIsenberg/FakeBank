using System;

namespace GunnarsBank
{
    public class Loan : BankTemplate
    {
        AccountType account = AccountType.Loan;
        float LoanAmount;
        float LoanTermInMonths;
        float Loanintrest;

        public Loan(string AccountH, int AccountNum, int bal, float loan, float term, float interest) : base(AccountH, AccountNum, bal)
        {
            LoanAmount = loan;
            LoanTermInMonths = term;
            Loanintrest = interest;
        }

        private float MonthPasses(float baseval, float intrest, float LoanAmount)
        {
            float ToAdd = baseval * ((intrest / 100) / 12);
            LoanAmount = LoanAmount + ToAdd;
            return LoanAmount;
        }

    }
}
