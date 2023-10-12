
using MockBankAccount;

var samsChecking = new SamBankAccount();

Console.ForegroundColor = ConsoleColor.DarkBlue;

Console.WriteLine("  ___            _       _                      _   ");
Console.WriteLine(" | _ ) __ _ _ _ | |__   /_\\  __ __ ___ _  _ _ _| |_ ");
Console.WriteLine(" | _ \\/ _` | ' \\| / /  / _ \\/ _/ _/ _ \\ || | ' \\  _|");
Console.WriteLine(" |___/\\__,_|_||_|_\\_\\ /_/ \\_\\__\\__\\___/\\_,_|_||_\\__|");


Console.WriteLine("Welcome to TrueCoders Bank, " +
    "where we are trying everyday to advance our online system to do anything you would need.");

Console.ForegroundColor = ConsoleColor.Black;


int expectedPassword = 2222;
int userPassword;

Console.WriteLine("Please enter your password");

if (!int.TryParse(Console.ReadLine(), out userPassword))
{
    
    Console.WriteLine("Invalid input, Enter a valid number");
}
else if (userPassword != expectedPassword)
{
    Console.WriteLine("Incorrect password. Access denied.");
}
else
{
    Console.WriteLine("Thank you for your password.Access granted.");

    while (true)
    {
        Console.WriteLine("What would you Like to do today? Print one of the following:");
        Console.WriteLine("1. Check Balance");
        Console.WriteLine("2. Deposit");
        Console.WriteLine("3. Withdraw");
        Console.WriteLine("4. Exit");

        int choice;
        if (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("Invalid input, Enter a valid number");
            continue;
        }
        switch (choice)
        {
            case 1:
                Console.WriteLine($"Your balance is {samsChecking.GetBalance()}");
                break;
            case 2:
                Console.WriteLine("Enter the amount you would like to deposit");
                double amount;
                if (!double.TryParse(Console.ReadLine(), out amount))
                {
                    Console.WriteLine("Invalid, please enter a valid number.");
                }

                samsChecking.Deposit(amount);
                Console.WriteLine("Deposite success!");
                break;


            case 3:
                Console.WriteLine("Enter the amount you would like to Withdarw");
                double withdrawl;
                if (!double.TryParse(Console.ReadLine(), out withdrawl))
                {
                    Console.WriteLine("Invalid, please enter a valid number.");
                }

                samsChecking.Withdraw(withdrawl);
                Console.WriteLine("Withdrawl success!");
                break;
            case 4:
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Thank you for using True Coders Bank! \n Have a Wonderful Day!");
                Console.ForegroundColor = ConsoleColor.Black;
                return;

            default:
                Console.WriteLine("Invald option");
                break;


        }
    }





}







//while (true)
//{
//    Console.WriteLine("What would you Like to do today? Print one of the following:");
//    Console.WriteLine("1. Check Balance");
//    Console.WriteLine("2. Deposit");
//    Console.WriteLine("3. Withdraw");
//    Console.WriteLine("4. Exit");

//    int choice;
//    if (!int.TryParse(Console.ReadLine(), out choice))
//    {
//        Console.WriteLine("Invalid input, Enter a valid number");
//        continue;
//    }
//    switch (choice)
//    {
//        case 1:
//            Console.WriteLine($"Your balance is {samsChecking.GetBalance()}");
//            break;
//        case 2:
//            Console.WriteLine("Enter the amount you would like to deposit");
//            double amount;
//            if (!double.TryParse(Console.ReadLine(), out amount))
//            {
//                Console.WriteLine("Invalid, please enter a valid number.");
//            }

//            samsChecking.Deposit(amount);
//            Console.WriteLine("Deposite success!");
//            break;


//        case 3:
//            Console.WriteLine("Enter the amount you would like to Withdarw");
//            double withdrawl;
//            if (!double.TryParse(Console.ReadLine(), out withdrawl))
//            {
//                Console.WriteLine("Invalid, please enter a valid number.");
//            }

//            samsChecking.Withdraw(withdrawl);
//            Console.WriteLine("Withdrawl success!");
//            break;
//        case 4:
//            Console.ForegroundColor = ConsoleColor.DarkBlue;
//            Console.WriteLine("Thank you for using True Coders Bank! \n Have a Wonderful Day!");
//            Console.ForegroundColor = ConsoleColor.Black;
//            return;

//        default:
//            Console.WriteLine("Invald option");
//            break;


//    }
//}





