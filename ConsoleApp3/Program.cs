// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

List<string> AllowedSigns = ["rock", "paper", "scissors"];
Dictionary<string, List<string>> WinningMap = [];
WinningMap["rock"] = ["scissors"];
WinningMap["paper"] = ["rock"];
WinningMap["scissors"] = ["paper"];
Console.WriteLine("What's your name");
string PlayerName = Console.ReadLine()!;

string CheckPlayerInput(string PlayerName)
{
    Console.WriteLine($"Hello {PlayerName}, choose your sign: {string.Join('/', AllowedSigns)}");
    string sign = Console.ReadLine();

    while(!AllowedSigns.Contains(sign, StringComparer.OrdinalIgnoreCase))
    {
        Console.WriteLine($"Incorrect, choose correct sign: {string.Join('/', AllowedSigns)}");
        sign = Console.ReadLine();

    } 
    return sign; 
}

