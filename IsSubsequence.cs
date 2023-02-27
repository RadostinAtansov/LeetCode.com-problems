



//Example 1:
string s1 = "abc", t1 = "ahbgdc";
//Output: true

//Example 2:
string s2 = "axc", t2 = "ahbgdc";
//Output: false


string s3 = "acb", t3 = "ahbgdc";
//Expected: false


string s4 = "aaaaaa";
string t4 = "bbaaaa";
//false

Console.WriteLine(IsSubsequence(s1, t1));

static bool IsSubsequence(string s, string t)
{
    if (s == String.Empty)
        return true;

    int count = 0;

    for (int i = 0; i < t.Length; i++)
        if (count < s.Length && s[count] == t[i])
            count++;

    return count == s.Length;
}