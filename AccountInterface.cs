using System;

public interface IAccount
{
    int UpdateBalance();
    void GetBalance();
    void GetAccountNumber();
    void GetAccountHolder();

    int GenerateTransactionID();
}

public interface ILoan
{
    void GetPrinciple();
    void GetInterestRate();
    void GetCollateral();
}
