using KataLibrary;
using System;

Console.WriteLine("KATA 004: Convert string to camel case\n");

Console.WriteLine("Give me some sentence with dashes or underscores instead of spaces: ");
string inputSentence = Console.ReadLine();

var convertedSentence = Kata.ToCamelCase(inputSentence);
Console.WriteLine("Converted sentence: ");
Console.WriteLine(convertedSentence);

Console.Write("\nPress any key...");
Console.ReadKey();