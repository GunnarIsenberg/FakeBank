using System;

namespace GunnarsBank
{
    public void Main()
    {
        Loan GunnarsLoan = new Loan("Gunnar Isenberg", 129432, 1000, 100000, 13, 3);
        Banker Caity = new Banker("Caitlyn Jacksopn", 345235, 10000);
        Banker Jessica = new Banker("Jesssica Runsten", 345235, 10000);
    }
}