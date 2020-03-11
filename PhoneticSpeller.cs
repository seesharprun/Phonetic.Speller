using System.Collections.Generic;

namespace Phonetic.Speller
{
    public sealed class PhoneticSpeller : IPhoneticSpeller
    {
        public IEnumerable<(string, IEnumerable<(char, string)>)> GetSpelling(params string[] words)
        {
            foreach(string word in words)
            {
                yield return (word, GetSpellingInternal(word));
            }

            IEnumerable<(char, string)> GetSpellingInternal(string word)
            {
                foreach(char character in word.Trim().ToUpper().ToCharArray())
                {
                    string nato = "Not Found";
                    PhoneticAlphabet.Alphabet.TryGetValue(character, out nato);
                    yield return (character, nato);
                }
            }
        }
    }
}