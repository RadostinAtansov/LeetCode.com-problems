


//You are given a string sentence that consist of words separated by spaces. Each word consists of lowercase and uppercase letters only.

//We would like to convert the sentence to "Goat Latin" (a made-up language similar to Pig Latin.) The rules of Goat Latin are as follows:

//If a word begins with a vowel ('a', 'e', 'i', 'o', or 'u'), append "ma" to the end of the word.
//For example, the word "apple" becomes "applema".
//If a word begins with a consonant (i.e., not a vowel), remove the first letter and append it to the end, then add "ma".
//For example, the word "goat" becomes "oatgma".
//Add one letter 'a' to the end of each word per its word index in the sentence, starting with 1.
//For example, the first word gets "a" added to the end, the second word gets "aa" added to the end, and so on.
//Return the final sentence representing the conversion from sentence to Goat Latin.



//Example 1:
string sentence1 = "I speak Goat Latin";
//Output: "Imaa peaksmaaa oatGmaaaa atinLmaaaaa"

//Example 2:
string sentence2 = "The quick brown fox jumped over the lazy dog";
//Output: "heTmaa uickqmaaa rownbmaaaa oxfmaaaaa umpedjmaaaaaa overmaaaaaaa hetmaaaaaaaa azylmaaaaaaaaa ogdmaaaaaaaaaa"

string test = "Each word consists of lowercase and uppercase letters only";

Console.WriteLine(ToGoatLatin(test));

static string ToGoatLatin(string sentence)
{
    string[] splitedSentance = sentence.Split(' ');

    for (int i = 0; i < splitedSentance.Length; i++)
    {
        char firstChar = splitedSentance[i][0];
        string word = splitedSentance[i];
        if (char.ToLower(firstChar) == 'a' || char.ToLower(firstChar) == 'e' ||
            char.ToLower(firstChar) == 'o' || char.ToLower(firstChar) == 'i' ||
            char.ToLower(firstChar) == 'u')
        {
            splitedSentance[i] = word += "ma" + new string('a', i + 1);
        }
        else
        {
            char fChar = word[0];
            word = word.Remove(0, 1);
            splitedSentance[i] = word + fChar + "ma" + new string('a', i + 1);
        }
    }

    return string.Join(' ', splitedSentance);
}