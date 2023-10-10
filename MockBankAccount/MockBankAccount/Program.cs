namespace MockBankAccount;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;

        Console.WriteLine("  ___            _       _                      _   ");
        Console.WriteLine(" | _ ) __ _ _ _ | |__   /_\\  __ __ ___ _  _ _ _| |_ ");
        Console.WriteLine(" | _ \\/ _` | ' \\| / /  / _ \\/ _/ _/ _ \\ || | ' \\  _|");
        Console.WriteLine(" |___/\\__,_|_||_|_\\_\\ /_/ \\_\\__\\__\\___/\\_,_|_||_\\__|");


        Console.WriteLine("Welcome to TrueCoders Bank, " +
            "where we are trying everyday to advance our online system to do anything you would need.");

        Console.ForegroundColor = ConsoleColor.Black;

        var samsChecking = new SamBankAccount();

        Console.WriteLine("What would you Like to do today? Print one of the following:");
        Console.WriteLine("Check Balance - Withdraw - Deposit");
        string userInput = Console.ReadLine();



        switch (userInput.ToLower())
        {
            case "check balance":
                Console.WriteLine($"Your balance is {samsChecking.GetBalance()}");
                break;
            case "deposit":
                Console.WriteLine($"How much would you like to deposit?");
                var amountToDeposit = double.Parse(Console.ReadLine());
                samsChecking.Deposit(amountToDeposit);
                Console.WriteLine($"Thank you! Your balance is now {samsChecking.GetBalance()}");
                break;
            case "withdraw":
                Console.WriteLine("How much would you like to Withdraw?");
                var amountToWithdraw = double.Parse(Console.ReadLine());
                samsChecking.Withdraw(amountToWithdraw);
                Console.WriteLine($"Thank you! Your balance is {samsChecking.GetBalance}");
                break;
            
        }

        Console.WriteLine("Would you like to do anything else today?");
        Console.WriteLine("y / n");
        Console.ReadLine();



    }
}

