using System;
using System.Linq;

namespace InternationalGunnarsBank
{
    class MoneyManager
    {
        Random newRand = new Random();
        private void deposit(Dictionary<int, int> history, int balance, int deposit)
        {
            int newBal = balance + deposit;
            int tNum = newRand.Next();
            int[] tPair = { tNum, newBal };
            AddTransaction(history, tPair);

        }

        private void AddTransaction(Dictionary<int, int> history, int[] tAdd)
        {
            history.Add(tAdd[0], tAdd[1]);
        }

        private void Withdraw(Dictionary<int, int> history, int balance, int despoit)
        { 
            int newBal = balance - despoit;
            int tNum = newRand.Next();
            int[] tPair = { tNum, newBal };
            AddTransaction(history, tPair);
        }
    } 
}