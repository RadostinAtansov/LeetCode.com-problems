

//Given a string s, reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.



//Example 1:

string s1 = "Let's take LeetCode contest";
//Output: "s'teL ekat edoCteeL tsetnoc"
//Example 2:

string s2 = "God Ding";
//Output: "doG gniD"

Console.WriteLine(ReverseWords(s1));

static string ReverseWords(string s)
{
	string[] strSplit = s.Split(" ");

	for (int i = 0; i < strSplit.Length; i++)
	{
		string strWord = strSplit[i];
		char[] word = strSplit[i].ToCharArray();
		Array.Reverse(word);
		string newWordReversed = new string(word);

		strSplit[i] = newWordReversed;
	}




    return string.Join(" ", strSplit);
}