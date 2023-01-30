
string s1 = "A man, a plan, a canal: Panama";
//Output: true
//Explanation: "amanaplanacanalpanama" is a palindrome.

string s2 = "race a car";
//Output: false
//Explanation: "raceacar" is not a palindrome.

string s3 = " ";
//Output: true


Console.WriteLine(IsPalindrome(s3));

static bool IsPalindrome(string s)
{
	List<char> list = new List<char>();

	for (int i = 0; i < s.Length; i++)
	{
		if (Char.IsLetterOrDigit(s[i]))
		{
			list.Add(Char.ToLower(s[i]));
		}
	}

	List<Char> normalList = new List<char>(list);
	list.Reverse();
	List<char> reversedList = list;

	for (int i = 0; i < normalList.Count; i++)
	{
		if (reversedList[i] != normalList[i])
		{
			return false;
		}
	}

	return true;
}