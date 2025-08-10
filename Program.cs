using System;
namespace ATM
{
    class Program
    {
        static void SelectTransaction(double balance)
        {
            Console.Write("1 -- Deposit \n2 -- Withdraw\n3 -- View Balance\n4 -- Exit\n");
            int Choice = int.Parse(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                    Deposit(balance);
                    break;

                case 2:
                    Withdraw(balance);
                    break;

                case 3:
                    Console.WriteLine("\nBalance = " + balance + "\n");
                    SelectTransaction(balance);
                    break;

                case 4:
                    Console.Write("Thank you , you can remove your card");
                    return;

                default:
                    Console.WriteLine("Invalid choice , select again");
                    SelectTransaction(balance);
                    break;
            }
        }
        static void Deposit(double balance) {
            Console.Write("\nBalance = " + balance);

            Console.Write("\nEnter the amount to deposite (limit is 10000) : ");
            double deposit_amount = double.Parse(Console.ReadLine());

            if (deposit_amount > 10000 || deposit_amount < 0)
            {
                Console.WriteLine("\nINVALID AMOUNT");
                Console.WriteLine("EXITING...\n");
                SelectTransaction(balance);
            }
            else
            {
                balance += deposit_amount;
                Console.WriteLine("Your balance = " + balance+"\n");
            }
            SelectTransaction(balance);

        }
        static void Withdraw(double balance) {
            Console.Write("\nEnter amount to withdraw (limit 10000) : ");
            int withdraw_amount = int.Parse(Console.ReadLine());

            if (withdraw_amount > balance)
            {
                Console.WriteLine("\nInsufficient amount");
                Console.WriteLine("Your balance is only " + balance);
                Console.WriteLine("Exiting...\n");
                SelectTransaction(balance);
            }
            else if (withdraw_amount > 10000)
            {
                Console.WriteLine("\nYou cannot withdraw this much amount");
                Console.WriteLine("Try Again...\n");
                SelectTransaction(balance);
            }
            else
            {
                balance -= withdraw_amount;
                Console.Write("\nYou have withdrawn " + withdraw_amount);
                Console.WriteLine("\nYour balance : " + balance + "\n");
                SelectTransaction(balance);
            }
        }
        static void Main (string[] args)
        {
            Console.Write("Enter the PIN : ");
            int PIN = int.Parse(Console.ReadLine());

            double balance = 10000;

            if (PIN == 1234) SelectTransaction(balance);
            else Console.Write("Invalid PIN"); return;
            


        }
    }
}