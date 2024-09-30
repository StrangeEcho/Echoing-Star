/*****
* name: Ruben Thomas
* date: 5.15.2024
* assignment: CIS214 Week 1 PA - Calculations & Unique Numbers
*/ 

using System;

public class Account {
    public string Name { get; set; }
    public double Balance { get; private set; }

    public Account(string name, double balance) {
        Name = name;
        if (balance > 0.0) {
            Balance = balance;
        }
    }
    
    public void Deposit(double amount) {
        if (amount > 0.0) {
            Balance += amount;
        }
    }
}
public class AccountClass {
    static void Main(string[] args) {
        Console.WriteLine("\nRuben Thomas - Week 1 GP Account Class\n");

        Account acct1 = new Account("Jane Green", 50.00);
        Account acct2 = new Account("John Blue", -7.53);

        Console.WriteLine("{0} balance: ${1:F2}", acct1.Name, acct1.Balance);
        Console.WriteLine("{0} balance: ${1:F2}", acct2.Name, acct2.Balance);

        Console.Write("\nEnter a deposit amount for Jane's account: $");
        string? val = Console.ReadLine();
        double deposit = Convert.ToInt32(val);
        Console.WriteLine("Addinbg ${0:F2} to Jane's account\n", val);
        acct1.Deposit(deposit);

        Console.Write("\nEnter a deposit amount for Jane's account: $");
        string? val1 = Console.ReadLine();
        double deposit1 = Convert.ToInt32(val1);
        Console.WriteLine("Addinbg ${0:F2} to Jane's account\n", val);
        acct2.Deposit(deposit1);

        Console.WriteLine("{0} balance: ${1:F2}", acct1.Name, acct1.Balance);
        Console.WriteLine("{0} balance: ${1:F2}", acct2.Name, acct2.Balance);        

    }
}