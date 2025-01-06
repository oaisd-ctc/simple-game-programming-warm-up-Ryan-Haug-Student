int botScore = 0;
int playerScore = 0;

Console.WriteLine("Dice Game");

Console.WriteLine();

Console.WriteLine("In this game you and a computer Rival will play 10 rounds");
Console.WriteLine("where you will each roll a 6-sided dice, and the player");
Console.WriteLine("with the highest dice value will win the round. The player");
Console.WriteLine("who wins the most rounds wins the game. Good luck!");

Console.WriteLine();

Console.Write("Press any key to start...");
Console.ReadKey(true);

Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"current round: {i + 1}");
    Console.WriteLine($"Standing scores; You: {playerScore}, Bot {botScore}");

    int rivalNum = Random.Shared.Next(1, 7);
    Console.WriteLine($"Rival rolled a {rivalNum}");
    
    Console.WriteLine("press any key to roll the dice");
    Console.ReadKey(true);

    int userNum = Random.Shared.Next(1, 7);
    Console.WriteLine($"You rolled a {userNum}");

    if (userNum > rivalNum)
    {
        playerScore++;
        Console.WriteLine("You Won!");
    }
    else if (userNum == rivalNum)
    {
        Console.WriteLine("The round is a draw");
    }
    else
    {
        botScore++;
        Console.WriteLine("You lost.");
    }

    Console.WriteLine("");
}

if (playerScore > botScore)
{
    Console.WriteLine("YOU WON THE GAME YEAHHHHHHHHH");
}
else if (playerScore == botScore)
{
    Console.WriteLine("the game ended in a draw");
}
else
{
    Console.WriteLine("you lost the game");
}