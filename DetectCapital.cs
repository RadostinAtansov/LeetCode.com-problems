

//We define the usage of capitals in a word to be right when one of the following cases holds:

//All letters in this word are capitals, like "USA".
//All letters in this word are not capitals, like "leetcode".
//Only the first letter in this word is capital, like "Google".
//Given a string word, return true if the usage of capitals in it is right.



//Example 1:
string word1 = "USA";
//Output: true

//Example 2:
string word2 = "FlaG";
//Output: false

Console.WriteLine(DetectCapitalUse("leetcodE"));

static bool DetectCapitalUse(string word)
{

	char[] chars = word.ToCharArray();
	int charsIsUppers = 0;
	int charsIslowers = 0;
	int firstCharIsUpper = 0;

    for (int i = 0; i < chars.Length; i++)
	{
		if (i == 0 && char.IsUpper(chars[i]))
		{
            firstCharIsUpper++;
        }
		if (char.IsUpper(chars[i]))
		{
			charsIsUppers++;
        }
		else if (char.IsLower(chars[i]))
        {
            charsIslowers++;
        }
    }

	if (chars.Length == charsIsUppers)
	{
		return true;
	}
	else if (chars.Length == charsIslowers)
    {
        return true;
    }
    else if (chars.Length == charsIslowers + firstCharIsUpper)
    {
        return true;
    }

    return false;
}