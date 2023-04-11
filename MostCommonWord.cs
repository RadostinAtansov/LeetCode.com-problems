

//Given a string paragraph and a string array of the banned words banned, return the most frequent word that is not banned. It is guaranteed there is at least one word that is not banned, and that the answer is unique.

//The words in paragraph are case-insensitive and the answer should be returned in lowercase.



//Example 1:
string paragraph1 = "Bob hit a ball, the hit BALL flew far after it was hit.";
string[] banned1 = { "hit" };
//Output: "ball"
//Explanation:
//"hit" occurs 3 times, but it is a banned word.
//"ball" occurs twice (and no other word does), so it is the most frequent non-banned word in the paragraph. 
//Note that words in the paragraph are not case sensitive,
//that punctuation is ignored (even if adjacent to words, such as "ball,"), 
//and that "hit" isn't the answer even though it occurs more because it is banned.

//Example 2:
string paragraph2 = "a.";
string[] banned2 = { };
//Output: "a"

string paragraph3 = "abc abc? abcd the jeff!";
string[] banned3 = { "abc", "abcd", "jeff" };

Console.WriteLine(MostCommonWord(paragraph1, banned1));

static string MostCommonWord(string paragraph, string[] banned)
{ 

    char[] splitChars = new[] { ' ', ',', '.', '!', '?', ';', '\'' };
    string paragraphToLower = paragraph.ToLower();
    List<string> splitWithChars = paragraphToLower.Split(splitChars, StringSplitOptions.RemoveEmptyEntries).ToList();

    for (int i = 0; i < banned.Length; i++)
    {
        string word = banned[i].ToLower();
        for (int l = 0; l < splitWithChars.Count; l++)
        {
            if (word == splitWithChars[l])
            {
                splitWithChars.RemoveAll(a => a == word);
            }
        }
    }

    int counterWords = 0;
    int tempCounterWords = 0;
    string movestFrequentWord = String.Empty;

    for (int i = 0; i < splitWithChars.Count; i++)
    {
        string wordI = splitWithChars[i].ToLower();
        for (int l = 0; l < splitWithChars.Count; l++)
        {
            string wordL = splitWithChars[l].ToLower();

            if (wordI == wordL)
            {
                counterWords++;
            }
        }

        if (counterWords > tempCounterWords)
        {
            tempCounterWords = counterWords;
            movestFrequentWord = wordI;
            counterWords = 0;
        }
        counterWords = 0;
    }


    return movestFrequentWord;
}
