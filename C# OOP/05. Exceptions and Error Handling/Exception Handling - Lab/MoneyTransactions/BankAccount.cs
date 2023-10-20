using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTransactions;

public class BankAccount
{
    private string number;
    private double balance;

    public BankAccount(string number, double balance)
    {
        this.number = number;
        this.balance = balance;
    }

    public string Number {
        get {return this.number; }
        set {this.number = value; } 
    }
    public double Balance
    {
        get { return this.balance; }
        set { this.balance = value; }
    }
    public void Deposit(string num, double balance)
    {
        this.Balance += balance;
        Console.WriteLine(this);
    }
    public void Withdraw(string num, double balance)
    {
        if(this.Balance - balance < 0)
        {
            throw new ArgumentException("Insufficient balance!");
        }
        this.Balance -= balance;
        Console.WriteLine(this);
    }
    
    public override string ToString()
    {
        return $"Account {number} has new balance: {balance:F2}";
    }
}
