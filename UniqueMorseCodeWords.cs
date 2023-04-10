//International Morse Code defines a standard encoding where each letter is mapped to a series of dots and dashes, as follows:

//'a' maps to ".-",
//'b' maps to "-...",
//'c' maps to "-.-.", and so on.
//For convenience, the full table for the 26 letters of the English alphabet is given below:

//[".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."]
//Given an array of strings words where each word can be written as a concatenation of the Morse code of each letter.

//For example, "cab" can be written as "-.-..--...", which is the concatenation of "-.-.", ".-", and "-...". We will call such a concatenation the transformation of a word.
//Return the number of different transformations among all words we have.



//Example 1:
string[] words1 = { "gin", "zen", "gig", "msg" };
//Output: 2
//Explanation: The transformation of each word is:
//"gin"-> "--...-."
//"zen"-> "--...-."
//"gig"-> "--...--."
//"msg"-> "--...--."
//There are 2 different transformations: "--...-." and "--...--.".

//Example 2:
string[] words2 = { "a" };
//Output: 1

Console.WriteLine(UniqueMorseRepresentations(words2));

static int UniqueMorseRepresentations(string[] words)
{
    Dictionary<char, string> morseCode = new Dictionary<char, string>()
    {
        { 'a', ".-" },
        { 'b', "-..."},
        { 'c', "-.-."},
        { 'd', "-.." },
        { 'e', "." },
        { 'f', "..-." },
        { 'g', "--." },
        { 'h', "...." },
        { 'i', ".." },
        { 'j', ".---" },
        { 'k', "-.-" },
        { 'l', ".-.." },
        { 'm', "--" },
        { 'n', "-." },
        { 'o', "---" },
        { 'p', ".--." },
        { 'q', "--.-" },
        { 'r', ".-." },
        { 's', "..." },
        { 't', "-" },
        { 'u', "..-" },
        { 'v', "...-" },
        { 'w', ".--" },
        { 'x', "-..-" },
        { 'y', "-.--" },
        { 'z', "--.." },
    };

    string wordInMorseCode = string.Empty;
    List<string> morseWords = new List<string>();

    for (int i = 0; i < words.Length; i++)
    {
        string word = words[i];
        for (int l = 0; l < word.Length; l++)
        {
            wordInMorseCode += morseCode[word[l]];
        }

        morseWords.Add(wordInMorseCode);
        wordInMorseCode = string.Empty;
    }

    morseWords = morseWords.Distinct().ToList();


    return morseWords.Count;
}