

//Given a string s, return true if the s can be palindrome after deleting at most one character from it.

//Example 1:
string s1 = "aba";
//Output: true

//Example 2:
string s2 = "abca";
//Output: true
//Explanation: You could delete the character 'c'.

//Example 3:
string s3 = "abcdefg";
//Output: false

string test = "deeee";

Console.WriteLine(ValidPalindrome(test));

static bool ValidPalindrome(string s)
{
    int left = 0, right = s.Length - 1;

    while (left < right)
    {
        if (s[left] == s[right])
        {
            left++;
            right--;
        }
        else
            return IsPalindrome(s, left + 1, right) || IsPalindrome(s, left, right - 1);
    }

    return true;
}

static bool IsPalindrome(string s, int left, int right)
{
    while (left < right)
    {
        if (s[left] != s[right])
            return false;
        left++;
        right--;
    }
    return true;
}