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

string GetCorrectRandomSign(string playerName)
{
    int signIndex = Random.Shared.Next(allowedSigns.Count);
    string sign = allowedSigns[signIndex];
    Console.WriteLine($"{playerName} selected {sign}");

    return sign;
}

const StringComparison stringComparison = StringComparison.OrdinalIgnoreCase;
int player1Score = 0;
int player2Score = 0;

while (true)
{
    string player1 = GetCorrectsign("Player 1");
    string player2 = GetCorrectRandomSign("Player 2");
    //Console.WriteLine("Play again?");
    //PlayerChoice = Console.ReadLine();
    


// 1. Pobierz indeks znaku podanego przez osobę drugą (np. 0, 1, 2) - nazwę to secondSignIndex
int secondSignIndex = allowedSigns.IndexOf(player2);
// 2. Wylicz indeks znaku, który wygrywa z podanym przez drugą  - wzór - (secondSignIndex + 1) % rozmiarListy
int winningSignIndex = (secondSignIndex + 1) % allowedSigns.Count;
// 3. Czy indeks znaku podanego przez pierwszą osobę to indeks wyliczony w punkcie 2.
int firstSignIndex = allowedSigns.IndexOf(player1);


if (player1.Equals(player2, stringComparison))
{
    Console.WriteLine("It's a draw!");
}
else if (firstSignIndex == winningSignIndex)
{
    Console.WriteLine("Player1 won!");
    player1Score += 1;
}
else
{
    Console.WriteLine("Player2 won!");
    player2Score += 1;
}
Console.WriteLine($"First player:{player1Score}");
Console.WriteLine($"Second player:{player2Score}");

if (player1Score >= 3 || player2Score >= 3)
{
   break;     
}
}