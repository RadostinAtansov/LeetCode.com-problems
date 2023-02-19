


//Example 1:
string allowed1 = "ab";
string[] words1 = { "ad", "bd", "aaab", "baa", "badab" };
//Output: 2
//Explanation: Strings "aaab" and "baa" are consistent since they only contain characters 'a' and 'b'.

//Example 2:
string allowed2 = "abc";
string[] words2 = { "a", "b", "c", "ab", "ac", "bc", "abc" };
//Output: 7
//Explanation: All strings are consistent.

//Example 3:
string allowed3 = "cad";
string[] words3 = { "cc", "acd", "b", "ba", "bac", "bad", "ac", "d" };
//Output: 4
//Explanation: Strings "cc", "acd", "ac", and "d" are consistent.


Console.WriteLine(CountConsistentStrings(allowed3, words3));

static int CountConsistentStrings(string allowed, string[] words)
{
	int counter = 0;

	for (int i = 0; i < words.Length; i++)
	{
		string word = words[i];
		for (int l = 0; l < word.Length; l++)
		{
			char charFromWord = word[l];
			if (!allowed.Contains(charFromWord))
			{
				break;
			}
			else if(word.Length - 1 == l)
			{
				counter++;
			}
		}

	}

    return counter;
}