# ATM Console Application

This is a basic console-based ATM simulation program written in C#. The application allows a user to log in with a PIN and perform basic banking operations such as depositing money, withdrawing money, and checking the account balance.

## Features
- PIN authentication (default PIN: 1234)
- Deposit money (limit: 10,000 per transaction)
- Withdraw money (limit: 10,000 per transaction)
- Check current balance
- Simple text-based menu

## How to Run
1. Open the project in Visual Studio or Visual Studio Code.
2. Build the project.
3. Run the application.
4. Enter the correct PIN to access the menu.
5. Choose an option from the displayed menu.

## Sample Output
Enter the PIN : 1234
1 -- Deposit
2 -- Withdraw
3 -- View Balance
4 -- Exit

## Notes
- The balance starts at 10,000 by default.
- If the wrong PIN is entered, the program will exit.
- The balance is not saved between sessions.
