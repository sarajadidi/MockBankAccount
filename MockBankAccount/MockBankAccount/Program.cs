namespace MockBankAccount;

class Program
{
    static void Main(string[] args)
    {
        var samsChecking = new SamBankAccount();

        Console.ForegroundColor = ConsoleColor.DarkBlue;

        Console.WriteLine("  ___            _       _                      _   ");
        Console.WriteLine(" | _ ) __ _ _ _ | |__   /_\\  __ __ ___ _  _ _ _| |_ ");
        Console.WriteLine(" | _ \\/ _` | ' \\| / /  / _ \\/ _/ _/ _ \\ || | ' \\  _|");
        Console.WriteLine(" |___/\\__,_|_||_|_\\_\\ /_/ \\_\\__\\__\\___/\\_,_|_||_\\__|");


        Console.WriteLine("Welcome to TrueCoders Bank, " +
            "where we are trying everyday to advance our online system to do anything you would need.");

        Console.ForegroundColor = ConsoleColor.Black;

        

        while (true)
        {
            Console.WriteLine("What would you Like to do today? Print one of the following:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Exit");

            int choice;
            if(!int.TryParse(Console.ReadLine(), out choice))
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
                    if(!double.TryParse(Console.ReadLine(), out amount))
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









        //switch (userInput.ToLower())
        //{
        //    case "check balance":
        //    case "checkbalance":
        //        Console.WriteLine($"Your balance is {samsChecking.GetBalance()}");
        //        break;
        //    case "deposit":
        //        Console.WriteLine($"How much would you like to deposit?");
        //        var amountToDeposit = double.Parse(Console.ReadLine());
        //        samsChecking.Deposit(amountToDeposit);
        //        Console.WriteLine($"Thank you! Your balance is now {samsChecking.GetBalance()}");
        //        break;
        //    case "withdraw":
        //        Console.WriteLine("How much would you like to Withdraw?");
        //        var amountToWithdraw = double.Parse(Console.ReadLine());
        //        samsChecking.Withdraw(amountToWithdraw);
        //        Console.WriteLine($"Thank you! Your balance is {samsChecking.GetBalance}");
        //        break;
        //default:
        //        Console.WriteLine("Invalid input");
        //break;

        //}




        Console.WriteLine("Would you like to do anything else today?");
        Console.WriteLine("y / n");
        Console.ReadLine();

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Thank you for using TrueCoders Bank!");
        Console.ForegroundColor = ConsoleColor.Black;
    }
}

