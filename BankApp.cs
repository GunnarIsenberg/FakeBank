using System;

namespace GunnarsBank
{
    public class Bank
    {
        public static void Main()
        {
            Loan GunnarsLoan = new Loan("Gunnar Isenberg", 129432, 1000, 100000, 13, 3);
            Banker Caity = new Banker("Caitlyn Jacksopn", 345235, 10000);
            Banker Jessica = new Banker("Jesssica Runsten", 345235, 10000);
            Banker Mike = new Banker("Mike Hawk", 345235, 10000);
            Banker Kate = new Banker("Kate Windsor", 345235, 10000);
            Banker Bob = new Banker("Bob Odenkirk", 345235, 10000);
            Banker Mary = new Banker("Mary Magdeline", 345235, 10000);
            Banker Caleb = new Banker("Caleb Write", 345235, 10000);
            Banker Jasmine = new Banker("Jasmine Stevens", 345235, 10000);
            Banker James = new Banker("James monroe", 345235, 10000);

            Caity.GetBalance();
            James.GetAccountHolder();
            Caity.UpdateBalance();
            GunnarsLoan.MonthPasses();
        }
    }

}