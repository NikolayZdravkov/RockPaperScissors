const string Rock = "Rock";
const string Paper = "Paper";
const string Scissors = "Scissors";

Console.WriteLine("Choose [r]ock, [p]aper or [s]cissors:");
string playerChoice = Console.ReadLine();

if (playerChoice == "r" || playerChoice == "rock")
{
    playerChoice = Rock;
}
else if (playerChoice == "p" || playerChoice == "paper")
{
    playerChoice = Paper;
}
else if (playerChoice == "s" || playerChoice == "scissors")
{
    playerChoice = Scissors;
}
else
{
    Console.WriteLine("Invalid command...Try again.");
    return;
}

Random random = new Random();
int computerRandomNum = random.Next(1, 4);

string computerMove = "";

switch(computerRandomNum)
{
    case 1:
        computerMove = Rock;
        break;
    case 2:
        computerMove = Paper;
        break;
    case 3:
        computerMove = Scissors;
        break;
}

Console.WriteLine($"The computer chose {computerMove}.");

if ((playerChoice == Rock && computerMove == Scissors) || 
    (playerChoice == Paper && computerMove == Rock) || 
    (playerChoice == Scissors && computerMove == Paper))
{
    Console.WriteLine("You win!");
}
else if ((computerMove == Rock && playerChoice == Scissors) ||
    (computerMove == Paper && playerChoice == Rock) ||
    (computerMove == Scissors && playerChoice == Paper))
{
    Console.WriteLine("You lose...");
}
else
{
    Console.WriteLine("It's a draw.");
}