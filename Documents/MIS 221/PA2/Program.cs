
    {
        RouteEm(DisplayMenu());
    }

    static string DisplayMenu()
    {
        Console.WriteLine("1. UNIT CONVERSION APP\n2. POS system\n3. Calorie count\n4. Exit\n(Input a number)");
        return Console.ReadLine();
    }

    static void RouteEm(string userChoice)
    {
        switch (userChoice)
        {
            case "1":
                CalculateUnits();
                break;
            case "2":
                POS();
                break;
            case "3":
                caloriePerCake();
                break;
           case "4":
                Console.WriteLine("Exiting...");
                break;    
            default:
                Console.WriteLine("Invalid choice. Please enter a valid option.");
                break;
        }
       
    }

    static void CalculateUnits()
    {
        double measureOut = 0.0;

        Console.WriteLine("Are you converting to or from gallons(To/From)?");
        string numInput = Console.ReadLine().ToLower();
        Console.WriteLine("What units are you working with?");
        string units = Console.ReadLine().ToLower();
        Console.WriteLine("How many units are you working with?");
        double amount = double.Parse(Console.ReadLine());

        if (numInput == "from")
        {
            if (units == "quarts")
            {
                measureOut = 4 * amount;
            }
            else if (units == "pints")
            {
                measureOut = 8 * amount;
            }
            else if (units == "cups")
            {
                measureOut = 15.773 * amount;
            }
            else if (units == "ounces")
            {
                measureOut = 128 * amount;
            }
            else if (units == "tablespoon")
            {
                measureOut = 256 * amount;
            }
            else if (units == "teaspoon")
            {
                measureOut = 768 * amount;
            }

            Console.WriteLine($"The converted value of {amount} Gallons is {measureOut} {units}");
        }
        else if (numInput == "to")
        {
            if (units == "quarts")
            {
                measureOut = amount / 4;
            }
            else if (units == "pints")
            {
                measureOut = amount / 8;
            }
            else if (units == "cups")
            {
                measureOut = amount / 15.733;
            }
            else if (units == "ounces")
            {
                measureOut = amount / 128;
            }
            else if (units == "tablespoon")
            {
                measureOut = amount / 256;
            }
            else if (units == "teaspoon")
            {
                measureOut = amount / 768;
            }

            Console.WriteLine($"The converted value of {amount} {units} is {measureOut} Gallons");
        }

        RouteEm(DisplayMenu());
    }

    static void POS()
    {
        double amtDue = 0;
        double priceOfCake = 28.63;
        double delivery = 4.99;
        double tax = 0.07;

        Console.WriteLine("How many cakes do you want to purchase?");
        int numCakes = int.Parse(Console.ReadLine());

        Console.WriteLine("Would you like the cake delivered(Y/N)?");
        string del = Console.ReadLine();

        Console.WriteLine("What percentage would you like to tip?");
        int amount = int.Parse(Console.ReadLine());
        double tipPerc = amount / 100;

        amtDue += priceOfCake * numCakes;
        if (del == "Y")
        {
            amtDue += delivery;
        }

        amtDue = amtDue * (1 + tax);

        double totalMod = 1 + tipPerc;

        amtDue = amtDue * totalMod;

        Console.WriteLine($"Amount due: {amtDue}");
        Console.WriteLine("Enter Amount paid");
        double amtPaid = double.Parse(Console.ReadLine());

        while (amtDue > amtPaid)
        {
            Console.WriteLine("Insufficient amount please try a new amount paid:");
            amtPaid = double.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Change due: ${amtPaid - amtDue}");

        RouteEm(DisplayMenu());
    }


    static void caloriePerCake()
    {
        int caloriePerCake = 1250;

        Console.Write("How many cakes did you eat? ");
        int numCakes = Convert.ToInt32(Console.ReadLine());

        int totalCalories = numCakes * caloriePerCake;

        Console.WriteLine($"Total calories consumed: {totalCalories}");

        RouteEm(DisplayMenu());
    }


