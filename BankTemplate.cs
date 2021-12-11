using System;


namespace GunnarsBank
{
    public class BankTemplate
    {
        List<int> transactions = new List<int>();
        string AccountHolder;
        int AccountNumber;
        float balance;


        private static int GenerateTransactionID(List<int> history)
        {
            Random r = new Random();

            while (true)
            {
                int transactionNumber = r.Next(10000, 99999);
                if (history.Contains(transactionNumber))
                {
                    continue;
                }
                else
                {
                    history.Add(transactionNumber);
                    break;
                }
            }

            return 1;
        }

        public BankTemplate(string AccountH, int AccountNum, float bal)
        {
            List<int> newlist = new List<int>();
            transactions = new List<int>();
            AccountHolder = AccountH;
            AccountNumber = AccountNum;
            balance = bal;
        }

        public void GetAccountHolder()
        {
            Console.WriteLine(AccountHolder);
        }

        public void GetAccountNumber()
        {
            Console.WriteLine(AccountNumber);
        }

        public void GetBalance()
        {
            Console.WriteLine(balance);
        }

        public static float UpdateBalance(float balance, TransactionType transaction, int total, List<int> Transactions)
        {
            int transactionType = (int)transaction.GetTypeCode();
            float newbal;



            Random r = new Random();

            while (true)
            {
                int transactionNumber = r.Next(10000, 99999);
                if (Transactions.Contains(transactionNumber))
                {
                    continue;
                }
                else
                {
                    Transactions.Add(transactionNumber);
                    break;
                }
            }

            switch (transactionType)

            {
                case 0:
                    newbal = balance + total;
                    return newbal;
                case 1:
                    newbal = balance - total;
                    return newbal;
            }

            return balance;
        }


    }

}
