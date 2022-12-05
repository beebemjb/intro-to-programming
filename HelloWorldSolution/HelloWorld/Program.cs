// See https://aka.ms/new-console-template for more information
using HelloWorld;
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");

Console.WriteLine("how many minutes?");
string? minutes = Console.ReadLine();

if (minutes is not null)
{
    DateUtils utils = new DateUtils();

    int mins = int.Parse(minutes);
    DateTime timeAtEndOfBreak = utils.TakeABreak(mins);
    Console.WriteLine($"ok come back at {timeAtEndOfBreak:T}");
}
else
{
    Console.WriteLine("write minutes");
}