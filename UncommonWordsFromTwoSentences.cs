

//A sentence is a string of single-space separated words where each word consists only of lowercase letters.

//A word is uncommon if it appears exactly once in one of the sentences, and does not appear in the other sentence.

//Given two sentences s1 and s2, return a list of all the uncommon words. You may return the answer in any order.



//Example 1:

using System.Linq;

string s1 = "this apple is sweet", s2 = "this apple is sour";
//Output: ["sweet","sour"]
//Example 2:

string s3 = "apple apple" , s4 = "banana" ;
//Output: ["banana"]

var result = UncommonFromSentences(s1, s2);

Console.WriteLine(string.Join(' ', result));

static string[] UncommonFromSentences(string s1, string s2)
{

    Dictionary<string, int> uncommonWords = new Dictionary<string, int>();
    List<string> uncommonWordsssssss = new List<string>();

    string[] s1Array = s1.Split(' ').ToArray();
    string[] s2Array = s2.Split(' ').ToArray();

    for (int i = 0; i < s1Array.Length; i++)
    {
        string word1 = s1Array[i];

        if (!uncommonWords.ContainsKey(word1))
        {
            uncommonWords.Add(word1, 1);
        }
        else
        {
            uncommonWords[word1]++;
        }
    }

    for (int i = 0; i < s2Array.Length; i++)
    {
        string word2 = s2Array[i];

        if (!uncommonWords.ContainsKey(word2))
        {
            uncommonWords.Add(word2, 1);
        }
        else
        {
            uncommonWords[word2]++;
        }
    }

    uncommonWordsssssss = uncommonWords.Where(kvp => kvp.Value == 1).Select(kvp => kvp.Key).ToList();


    return uncommonWordsssssss.ToArray();
}