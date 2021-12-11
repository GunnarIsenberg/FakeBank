using System;

namespace GunnarsBank
{
    public class Banker : BankTemplate
    {
        AccountType account = AccountType.Banking;

        public Banker(string AccountH, int AccountNum, int bal) : base(AccountH, AccountNum, bal)
        {

        }
    }
}
