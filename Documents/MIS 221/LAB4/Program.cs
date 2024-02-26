

    
string userInput = GetMenuChoice();

while (userInput != "3")
{
    RouteEm(userInput);
    userInput = GetMenuChoice();
}
    

    static string GetMenuChoice()
    {
        DisplayMenu();
        return Console.ReadLine();
    }

    static void DisplayMenu()
    {
        Console.WriteLine(@"
            1. Start Microwave Timer
            2. Quick Defrost
            3. Exit
        ");
    }

    static void RouteEm(string userInput)
    {
        switch (userInput)
        {
            case "1":
                StartMicrowaveTimer();
                break;
            case "2":
                QuickDefrost();
                break;
            case "3":
                Console.WriteLine("Exiting...");
                break;
            default:
                Console.WriteLine("Invalid Input");
                break;
        }
    }

    static void StartMicrowaveTimer()
    {
        Console.Write("Enter the number of minutes: ");
        int minutes = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of seconds: ");
        int seconds = int.Parse(Console.ReadLine());

        Console.WriteLine("\nStarting Timer...");

        for (int m = minutes; m >= 0; m--)
        {
            for (int s = (m == minutes) ? seconds : 59; s >= 0; s--)
            {
                Console.WriteLine($"Time remaining: {m:00}:{s:00}");
                System.Threading.Thread.Sleep(1000); 
            }
        }

        Console.WriteLine("\nTimer Completed!");
    }

    static void QuickDefrost()
    {
        Console.Write("Enter the number of seconds: ");
        int seconds = int.Parse(Console.ReadLine());

        Console.WriteLine("\nStarting Quick Defrost...");

        for (int s = seconds; s >= 0; s--)
        {
            Console.WriteLine($"Time remaining: {s} seconds");
            System.Threading.Thread.Sleep(1000); 
        }

        Console.WriteLine("\nFood Ready!");
    }

