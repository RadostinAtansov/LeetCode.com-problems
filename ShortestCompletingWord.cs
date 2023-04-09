


//Given a string licensePlate and an array of strings words, find the shortest completing word in words.

//A completing word is a word that contains all the letters in licensePlate. Ignore numbers and spaces in licensePlate, and treat letters as case insensitive. If a letter appears more than once in licensePlate, then it must appear in the word the same number of times or more.

//For example, if licensePlate = "aBc 12c", then it contains letters 'a', 'b' (ignoring case), and 'c' twice.Possible completing words are "abccdef", "caaacab", and "cbca".

//Return the shortest completing word in words. It is guaranteed an answer exists. If there are multiple shortest completing words, return the first one that occurs in words.



//Example 1:

string licensePlate1 = "1s3 PSt";
string[] words1 = { "step", "steps", "stripe", "stepple" };
//Output: "steps"
//Explanation: licensePlate contains letters 's', 'p', 's'(ignoring case), and 't'.
//"step" contains 't' and 'p', but only contains 1 's'.
//"steps" contains 't', 'p', and both 's' characters.
//"stripe" is missing an 's'.
//"stepple" is missing an 's'.
//Since "steps" is the only word containing all the letters, that is the answer.
//Example 2:

string licensePlate2 = "1s3 456";
string[] words2 = { "looks", "pest", "stew", "show" };
//Output: "pest"
//Explanation: licensePlate only contains the letter 's'. All the words contain 's', but among these "pest", "stew", and "show" are shortest. The answer is "pest" because it is the word that appears earliest of the 3.

Console.WriteLine(ShortestCompletingWord(licensePlate1, words1));

static string ShortestCompletingWord(string licensePlate, string[] words)
{
	string letters = String.Empty;
	int wordLength = int.MaxValue;
	int maxLettersInWordAdnShortestWord = 0;
	int tempMaxLettersInWordAdnShortestWord = 0;
	string tempWord = String.Empty;

    for (int i = 0; i < licensePlate.Length; i++)
	{
		if (char.IsLetter(licensePlate[i]))
		{
			
			letters += char.ToLower(licensePlate[i]);
        }
	}

	for (int i = 0; i < words.Length; i++)
	{
		string word = words[i];

		for (int l = 0; l < letters.Length; l++)
		{
			char c = letters[l];

			if (word.Contains(c))
			{
				int index = word.IndexOf(c);
				word = word.Remove(index, 1);
				maxLettersInWordAdnShortestWord++;
			}
		}

		if ((maxLettersInWordAdnShortestWord > tempMaxLettersInWordAdnShortestWord) ||
            (maxLettersInWordAdnShortestWord >= tempMaxLettersInWordAdnShortestWord && words[i].Length < wordLength))
		{
			tempMaxLettersInWordAdnShortestWord = maxLettersInWordAdnShortestWord;
			wordLength = words[i].Length;
			tempWord = words[i];
			maxLettersInWordAdnShortestWord = 0; 

        }
		maxLettersInWordAdnShortestWord = 0;
	}

    return tempWord;
}