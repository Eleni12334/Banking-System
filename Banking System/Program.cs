using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            string holderName;
            Console.WriteLine("Enter the card holder's name: ");
            holderName = Console.ReadLine();
            decimal balance = 0;

            bool exit = false;
            string userInput;

            while (exit == false)
            {
                Console.WriteLine("Press:");
                Console.WriteLine("1 - To deposit money");
                Console.WriteLine("2 - To withdraw money");
                Console.WriteLine("3 - To view your balance");
                Console.WriteLine("4 - To exit");
                userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    Console.WriteLine("Hello " + holderName + ",");
                    balance = deposit(balance);
                }
                else if (userInput == "2")
                {
                    Console.WriteLine("Hello " + holderName + ",");
                    balance = withdraw(balance);
                }
                else if (userInput == "3")
                {
                    Console.WriteLine("Hello " + holderName + ",");
                    Console.WriteLine("Your current balance is: £" + balance);
                }
                else if (userInput == "4")
                {
                    exit = true;
                }
            }
        }

        static Boolean validTransaction(string strChange)
        {
            decimal change;
            return(decimal.TryParse(strChange, out change));
        }

        static decimal withdraw(decimal balance)
        {
            string strWithdraw;
            decimal withdraw;
            Console.WriteLine("Current balance: £" + balance);
            Console.WriteLine("Enter how much you would like to withdraw: ");
            strWithdraw = Console.ReadLine();
            bool valid = false;

            valid = validTransaction(strWithdraw);
            while (valid == false)
            {
                Console.WriteLine("Invalid input. Please enter how much you would like to withdraw:");
                strWithdraw = Console.ReadLine();
                valid = validTransaction(strWithdraw);
            }

            withdraw = Convert.ToDecimal(strWithdraw);

            if (balance-withdraw < 0)
            {
                Console.WriteLine("This withdrawal is invalid. You do not have enough money.");
                return balance;
            }

            balance = balance - withdraw;
            Console.WriteLine("- £" + withdraw);
            Console.WriteLine("Your balance is now: £" + balance);
            return balance;
        }

        static decimal deposit(decimal balance)
        {
            decimal deposit;
            string strDeposit;
            Console.WriteLine("Current balance: £" + balance);
            Console.WriteLine("Enter how much you would like to deposit: ");
            strDeposit = Console.ReadLine();

            bool valid = false;

            valid = validTransaction(strDeposit);
            while (valid == false)
            {
                Console.WriteLine("Invalid input. Please enter how much you would like to deposit:");
                strDeposit = Console.ReadLine();
                valid = validTransaction(strDeposit);
            }

            deposit = Convert.ToDecimal(strDeposit);

            balance = balance + deposit;
            Console.WriteLine("+ £" + deposit);
            Console.WriteLine("Your balance is now: £" + balance);
            return balance;
        }
    }
}



this is a example
