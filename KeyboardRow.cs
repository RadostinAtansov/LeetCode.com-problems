

//Companies
//Given an array of strings words, return the words that can be typed using letters of the alphabet on only one row of American keyboard like the image below.

//In the American keyboard:

//the first row consists of the characters "qwertyuiop",
//the second row consists of the characters "asdfghjkl", and
//the third row consists of the characters "zxcvbnm".


//Example 1:
string[] words1 = {"Hello", "Alaska", "Dad", "Peace"};



//Output: ["Alaska","Dad"]

//Example 2:
string[] words2 = { "omk" };
//Output: []

//Example 3:
string[] words3 = { "adsdf", "sfd" };
//Output: ["adsdf","sfd"]

Console.WriteLine(string.Join(',', FindWords(words3)));

static string[] FindWords(string[] words)
{
    List<string> result = new List<string>();
    string firstKeyboardRow = "qwertyuiop";
    string secondKeyboardRow = "asdfghjkl";
    string thirdKeyboardRow = "zxcvbnm";

 
        var check1 = CheckFirstRow(result, firstKeyboardRow, words);
        var check2 = CheckFirstRow(result, secondKeyboardRow, words);
        var check3 = CheckFirstRow(result, thirdKeyboardRow, words);
    

    return result.ToArray();
}


static List<string> CheckFirstRow(List<string> result, string checkrow, string[] words)
{
    int counter = 0;


    for (int i = 0; i < words.Length; i++)
    {
        string word = words[i];

        for (int j = 0; j < word.Length; j++)
        {
            char c = char.ToLower(word[j]);
            if (!checkrow.Contains(c))
            {
                counter = 0;
                break;
            }
            else
            {
                counter++;
            }
        }
        if (word.Length == counter)
        {
            result.Add(word);
            counter = 0;
        }
    }
    return result;
}