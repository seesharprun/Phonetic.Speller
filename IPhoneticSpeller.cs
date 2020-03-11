using System.Collections.Generic;

namespace Phonetic.Speller
{
    public interface IPhoneticSpeller
    {
        IEnumerable<(string, IEnumerable<(char, string)>)> GetSpelling(params string[] words);
    }
}