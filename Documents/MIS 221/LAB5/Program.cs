
    {
        string userInput;
        do
        {
            userInput = GetMenuChoice();
            RouteEm(userInput);
        } 
        while (userInput != "3");
    }

    static string GetMenuChoice()
    {
        DisplayMenu();
        return Console.ReadLine();
    }

    static void DisplayMenu()
    {
        Console.WriteLine(@"
            1. Display Deck of Cards
            2. Display Deck of Shuffled Cards
            3. Exit
        ");
    }

    static void RouteEm(string userInput)
    {
        switch (userInput)
        {
            case "1":
                DisplayDeck();
                break;
            case "2":
                DisplayShuffledDeck();
                break;
            case "3":
                Console.WriteLine("Exiting...");
                break;
            default:
                Console.WriteLine("Invalid Input");
                break;
        }
    }

    static void DisplayDeck()
    {
        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
        string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

        for (int i = 0; i < suits.Length; i++)
        {
            for (int j = 0; j < ranks.Length; j++)
            {
                Console.WriteLine($"{ranks[j]} of {suits[i]}");
            }
        }
    }

    static void DisplayShuffledDeck()
    {
        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
        string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

        Random rnd = new Random();
        int numberOfCards = suits.Length * ranks.Length;
        string[] deck = new string[numberOfCards];

        // Constructs the deck
        for (int i = 0; i < suits.Length; i++)
        {
            for (int j = 0; j < ranks.Length; j++)
            {
                deck[i * ranks.Length + j] = $"{ranks[j]} of {suits[i]}";
            }
        }

        // Shuffles deck
        for (int i = 0; i < numberOfCards; i++)
        {
            int randomIndex = rnd.Next(i, numberOfCards);
            string temp = deck[i];
            deck[i] = deck[randomIndex];
            deck[randomIndex] = temp;
        }

        // Displays the shuffled deck
        for (int i = 0; i < deck.Length; i++)
        {
            Console.WriteLine(deck[i]);
        }
    }


