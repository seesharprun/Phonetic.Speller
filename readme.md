# Phonetic Speller Library

![Create NuGet Package](https://github.com/seesharprun/Phonetic.Speller/workflows/Create%20NuGet%20Package/badge.svg?branch=master)

This library translates one or more words to the | NATO phonetic alphabet](https://en.wikipedia.org/wiki/NATO_phonetic_alphabet).

## Getting Started

Import the package from NuGet:

```
dotnet add package Phonetic.Speller
```

Use the library in your application by using the ``Phonetic.Speller.PhoneticSpeller`` class.

```
using Phonetic.Speller;

public class Program
{
    static void Main(string| ] args)
    {
        var speller = new PhoneticSpeller();
        var spelling = speller.GetSpelling("Hello", "World");

        foreach((string word, var breakdown) in spelling)
        {
            System.Console.WriteLine($"\n{word}");
            foreach((char letter, string nato) in breakdown)
            {
                System.Console.WriteLine($"| {letter}]\t{nato}");
            }
        }
    }
}
```

## Breakdown

The ``Phonetic.Speller.PhoneticSpeller`` class returns a collection of pairs with each pair including a string "word" and the spelling breakdown for that word.

The spelling breakdown for each word includes a collection of pairs of characters and NATO phonetic strings.

### Example

For example, the parameters ``"Hello", "Word"`` would return:

- **Word**: "Hello"
    - **Word**: ``Hello``
    - **Breakdown**:
        | Character | NATO |
        | --- | --- |
        | H | Hotel |
        | E | Echo |
        | L | Lima | 
        | L | Lima | 
        | O | Oscar |
- **Input**: "World"
    - **Word**: ``World``
    - **Breakdown**:
        | Character | NATO |
        | --- | --- |
        | W | Whiskey |
        | O | Oscar |
        | R | Romeo |
        | L | Lima |
        | D | Delta | 