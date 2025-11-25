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
}
else
{
    Console.WriteLine("Player2 won!");
}