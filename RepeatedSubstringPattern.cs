

//Given a string s, check if it can be constructed by taking a substring of it and appending multiple copies of the substring together.



//Example 1:
string s1 = "abab";
//Output: true
//Explanation: It is the substring "ab" twice.

//Example 2:
string s2 = "aba";
//Output: false
//Example 3:

string s3 = "abcabcabcabc";
//Output: true
//Explanation: It is the substring "abc" four times or the substring "abcabc" twice.

Console.WriteLine(RepeatedSubstringPattern(s3));

static bool RepeatedSubstringPattern(string s)
{
    int n = s.Length;
    string str = "";
    int x = n;
    int div = 1;
    for (int i = 0; i < n / 2; i++)
    {
        str += s[i];
        string newStr = string.Concat(Enumerable.Repeat(str, x / div));
        if (newStr.Equals(s))
            return true;
        div++;
    }
    return false;
}