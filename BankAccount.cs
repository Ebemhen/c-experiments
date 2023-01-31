using System;
namespace BankAccountApp
{
	class BankAccount
	{
		public string accountName;
		public int accountNumber;
		public double accountBalance;
		
		public BankAccount(string name, int number){
			accountName = name;
			accountNumber = number;
		}
		
		public int getAccountNumber(){
			return accountNumber;
		}
		
		public void setAccountBalance(int newNumber){
			accountNumber = newNumber;
		}
	}
	
	class SavingsAccount : BankAccount
	{
		public double interestRate;
		public SavingsAccount(string accName, int accNumber, double balance, double rate):base(accName, accNumber){
			interestRate = rate;
			accountBalance = balance;
		}
		
		public double monthlyInterest(){
			return(accountBalance*interestRate);
		}
	}
    
    class Program 
    {
        static void Main(string[] args) 
        {
        	SavingsAccount SaveAccount = new SavingsAccount("Nwabuife Divine",124572667,24800.50,0.50);
        	Console.WriteLine("The monthly interest for {0}, is: {1}",SaveAccount.accountName, SaveAccount.monthlyInterest());
        }
    }
}