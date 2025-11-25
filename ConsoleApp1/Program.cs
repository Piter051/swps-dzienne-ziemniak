// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
List<string> allowedSigns = ["rock", "paper", "scissors"];
string GetCorrectsign(string playerName)
{   
    Console.WriteLine($"{playerName}, choose your sign ({string.Join('/', allowedSigns)})");
    string sign = Console.ReadLine()!;


    while (!allowedSigns.Contains(sign, StringComparer.OrdinalIgnoreCase))
    {
        Console.WriteLine($"{playerName}, choose correct sign({string.Join('/', allowedSigns)})");
        sign = Console.ReadLine()!;
    }
    return sign;
}
const StringComparison stringComparison = StringComparison.OrdinalIgnoreCase;

string player1 = GetCorrectsign("Player 1");

string player2 = GetCorrectsign("Player 2");

int secondsignIndex = allowedSigns.IndexOf(player2);

int winningSignIndex = (secondsignIndex + 1)


if (player1.Equals(player2, stringComparison))
{
    Console.WriteLine("It's a draw!");
}
else if ((player1.Equals(allowedSigns[0], stringComparison) && player2.Equals(allowedSigns[2], stringComparison))
    ||  (player1.Equals(allowedSigns[1], stringComparison) && player2.Equals(allowedSigns[0], stringComparison))
    ||  (player1.Equals(allowedSigns[2], stringComparison) && player2.Equals(allowedSigns[1], stringComparison)))
{
    Console.WriteLine("Player1 won!");
}
else
{
    Console.WriteLine("Player2 won!");
}