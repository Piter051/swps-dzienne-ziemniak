// See https://aka.ms/new-console-template for more information

List<string> AllowedSigns = ["rock", "paper", "scissors"];
Dictionary<string, List<string>> WinningMap = [];
WinningMap["rock"] = ["scissors"];
WinningMap["paper"] = ["rock"];
WinningMap["scissors"] = ["paper"];

string CheckPlayerInput(string playerName)
{
    Console.WriteLine($"Hello {playerName}, choose your sign: {string.Join('/', AllowedSigns)}");
    string sign = Console.ReadLine()!;

    while(!AllowedSigns.Contains(sign, StringComparer.OrdinalIgnoreCase))
    {
        Console.WriteLine($"Incorrect{playerName}, choose correct sign: {string.Join('/', AllowedSigns)}");
        sign = Console.ReadLine()!;

    } 
    return sign; 
}

string RandomSign(string playerName)
{
    int SignIndex = Random.Shared.Next(AllowedSigns.Count);
    string sign = AllowedSigns[SignIndex];
    Console.WriteLine($"{playerName} chose {sign}");

    return sign;
}

const StringComparison stringComparison = StringComparison.OrdinalIgnoreCase;

int player1Score = 0;
int player2Score = 0;

Console.WriteLine("Player 1 what's your name?");
string firstPlayerName = Console.ReadLine()!;

Console.WriteLine("Player 2 what's your name?");
string secondPlayerName = Console.ReadLine()!;

Console.WriteLine("How many wins?");
string NumberOfWinsInText = Console.ReadLine()!;

bool ConvertedToNumber = uint.TryParse(NumberOfWinsInText, out uint NumberOfWins);

while (!ConvertedToNumber || NumberOfWins <= 0)
{
    NumberOfWinsInText = Console.ReadLine()!;
    ConvertedToNumber = uint.TryParse(NumberOfWinsInText, out NumberOfWins);
}

while (NumberOfWins> player1Score && NumberOfWins > player2Score)
{
    string player1 = CheckPlayerInput("Player 1");
 string player2 = RandomSign("Player 2");

    List<string> SignsLosingWithFirstSign = WinningMap[player1];

    if (player1.Equals(player2, stringComparison))
    {
        Console.WriteLine("It's a draw!");
    }
    else if (SignsLosingWithFirstSign.Contains(player2, StringComparer.OrdinalIgnoreCase))
    {
        Console.WriteLine($"{firstPlayerName} won!");
        player1Score += 1; 
    }
    else
    {
        Console.WriteLine($"{secondPlayerName} won!");
        player2Score += 1;
    }
        Console.WriteLine($"{firstPlayerName}:{player1Score}");
        Console.WriteLine($"{secondPlayerName}:{player2Score}");

}

