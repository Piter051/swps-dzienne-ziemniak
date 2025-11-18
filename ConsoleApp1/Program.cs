// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
const StringComparison stringComparison = StringComparison.OrdinalIgnoreCase;

List<string> allowedSigns = ["rock", "paper", "scissors"];
Console.WriteLine($"Hey let's play (({string.Join('/', allowedSigns)}) \n Player 1 please write your input:");
Console.WriteLine($"Hey let's play {allowedSigns[0]}, {allowedSigns[1]}, {allowedSigns[2]} \n Player 1 please write your input:");
string player1 = Console.ReadLine()!;


while (!(player1.Equals(allowedSigns[0], stringComparison) || player1.Equals(allowedSigns[1], stringComparison) || player1.Equals(allowedSigns[2], stringComparison)))
{
    Console.WriteLine($"Player1, choose correct sign({string.Join('/', allowedSigns)}");
    player1 = Console.ReadLine()!;
}
while (allowedSigns.Contains(player1))
Console.WriteLine("Player 2 please write your input:");
string player2 = Console.ReadLine()!;


// typ nazwa;
// typ nazwa = wartość:

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