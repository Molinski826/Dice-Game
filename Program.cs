class CrapGame
{
    static void Main(string[] args)
    
    
    {
        bool continueRolling = true;
        while (continueRolling== true)
        {
            Console.Write("Enter the number of sides of the dice that is positive and even: ");
            int diceNumber = -1;
            while (int.TryParse(Console.ReadLine(), out diceNumber) == false || diceNumber <= 0 || diceNumber % 2 == 1)
            {
                Console.WriteLine("Please choose a valid number");
            }
            {
                Console.WriteLine("Rolling the dice...");
                Console.WriteLine("Snaps Fingers...");
                int die1 = RollDice(diceNumber);
                int die2 = RollDice(diceNumber);

                Console.WriteLine($"You rolled a {die1} and a {die2}. Total: {die1 + die2}");

                if (diceNumber == 6)
                {
                    string combinationMessage = GetCrapsMessage(die1, die2);
                    string totalMessage = GetTotalMessage(die1 + die2);
                    if (!string.IsNullOrEmpty(combinationMessage))
                    {
                        Console.WriteLine(combinationMessage);
                    }

                    if (!string.IsNullOrEmpty(totalMessage))
                    {
                        Console.WriteLine(totalMessage);
                    }
                }
                while (true)
                {
                    {
                        Console.Write("Do you want to roll the dice again? (y/n): ");
                        string rollAgain = Console.ReadLine();
                        if (rollAgain == "y")
                        {
                            break;
                        }
                        else if (rollAgain == "n")
                        {
                            continueRolling = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("invalid choice");
                        }
                    }
                }
            }
            
            
        
        }
    }
    static int RollDice(int sides)
    {
        Random random = new Random();
        return random.Next(1, sides + 1);
    }

    static string GetCrapsMessage(int die1, int die2)
    {
        if (die1 == 1 && die2 == 1) return "Snake Eyes!";
        if ((die1 == 1 && die2 == 2) || (die1 == 2 && die2 == 1)) return "Ace Deuce!";
        if (die1 == 6 && die2 == 6) return "Box Cars!";
        return string.Empty;
    }

    static string GetTotalMessage(int total)
    {
        if (total == 7 || total == 11) return "Win!";
        if (total == 2 || total == 3 || total == 12) return "Craps!";
        return string.Empty;
    }
}


    

    