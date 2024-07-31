using System.Text;

namespace codewars.duplicateEncoder;

// https://www.codewars.com/kata/54b42f9314d9229fd6000d9c/train/csharp
using System.Collections.Generic;

public class DuplicateEncoder
{
    public static string DuplicateEncode(string word)
    {
        word = word.ToLower();
        var result = new StringBuilder(word.Length);

        Dictionary<char, int> frequency = new();

        foreach (var letter in word)
        {
            if (!frequency.TryAdd(letter, 1))
                frequency[letter]++;
        }

        foreach (var letter in word)
        {
            result.Append(frequency[letter] > 1 ? ')' : '(');
        }

        return result.ToString();
    }
}