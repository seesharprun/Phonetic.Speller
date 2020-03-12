# Phonetic Speller Library

![Create NuGet Package](https://github.com/seesharprun/Phonetic.Speller/workflows/Create%20NuGet%20Package/badge.svg?branch=master)

## Getting Started

```
dotnet add package Phonetic.Speller
```

```
using Phonetic.Speller;

public class Program
{
    static void Main(string[] args)
    {
        var speller = new PhoneticSpeller();
        var spelling = speller.GetSpelling("Hello", "World");

        foreach((char letter, string nato) in spelling)
        {
            System.Console.WriteLine($"[{letter}]\t{nato}");
        }
    }
}
```