
//Given a string s and an integer k, reverse the first k characters for every 2k characters counting from the start of the string.

//If there are fewer than k characters left, reverse all of them. If there are less than 2k but greater than or equal to k characters, then reverse the first k characters and leave the other as original.



//Example 1:
string s1 = "abcdefg";
int k1 = 2;
//Output: "bacdfeg";

//Example 2:
string s2 = "abcd"; 
int k2 = 2;
//Output: "bacd"


string s3 = "hyzqyljrnigxvdtneasepfahmtyhlohwxmkqcdfehybknvdmfrfvtbsovjbdhevlfxpdaovjgunjqlimjkfnqcqnajmebeddqsgl";
int k3 = 39;

Console.WriteLine(ReverseStr(s3, k3));

static string ReverseStr(string s, int k)
{
    char[] chars = s.ToCharArray();
    string subStr = string.Empty;
	char[] chars2;
    string strNew;

    if (s.Length < k)
	{
		Array.Reverse(chars);
		return new string(chars);
	}
	else if (s.Length <= (2 * k) && s.Length >= k)
	{
		subStr = s.Substring(0, k);
		chars2 = subStr.ToCharArray();
		Array.Reverse(chars2);
		strNew = new string(chars2);

        s = s.Replace(subStr, strNew);

		return s;
	}

	int start = 0;

    while (start < s.Length)
	{
		int reminder = Math.Abs(start - s.Length);

		if (reminder < k)
		{
            subStr = s.Substring(start);
            chars2 = subStr.ToCharArray();
            Array.Reverse(chars2);
            strNew = new string(chars2);

            s = s.Replace(subStr, strNew);
            start += (2 * k);

        }
        else
		{
			subStr = s.Substring(start, k);
			chars2 = subStr.ToCharArray();
			Array.Reverse(chars2);
			strNew = new string(chars2);
			s = s.Replace(subStr, strNew);
			start += (2 * k);
		}

	}

    return s;
}