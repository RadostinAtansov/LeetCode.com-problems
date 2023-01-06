string s1 = "Hello World";
//Output: 5
string s2 = "   fly me   to   the moon  ";
//Output: 4
string s3 = "luffy is still joyboy";
//Output: 6

Console.WriteLine(LengthOfLastWord(s3));

static int LengthOfLastWord(string s)
{
    string[] splitString = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    string lastWord = splitString[splitString.Length - 1];

    return lastWord.Length;
}