


//Example 1:
string s1 = "anagram", t1 = "nagaram";
//Output: true

//Example 2:
string s2 = "rat", t2 = "car";
//Output: false


string s3 = "aacc", t3 = "ccac";


Console.WriteLine(IsAnagram(s3, t3));

static bool IsAnagram(string s, string t)
{

    int[] record = new int[26];

    for (int i = 0; i < s.Length; i++)
    {
        record[s[i] - 'a']++;     // 并不需要记住字符a的ASCII，只要求出一个相对数值就可以了
    }

    for (int i = 0; i < t.Length; i++)
    {
        record[t[i] - 'a']--;                                     //===> faster
    }

    for (int i = 0; i < 26; i++)
    {
        if (record[i] != 0)
        {               // record数组如果有的元素不为零0，说明字符串s和t 一定是谁多了字符或者谁少了字符。
            return false;
        }
    }
    return true;


    //if(s.Length != t.Length)
    //{
    //	return false;
    //}
    //for (int i = 0; i < s.Length; i++)
    //{
    //	char c = s[i];
    //	if (t.Contains(c))
    //	{
    //		int index = t.IndexOf(c);
    //		t = t.Remove(index, 1);
    //	}
    //	else
    //	{
    //		return false;
    //	}
    //   }

    //   return true;
}