


//Example 1:
string s1 = "abccccdd";
//Output: 7
//Explanation: One longest palindrome that can be built is "dccaccd", whose length is 7.

//Example 2:
string s2 = "a";
//Output: 1
//Explanation: The longest palindrome that can be built is "a", whose length is 1.

Console.WriteLine(LongestPalindrome(s1));

static int LongestPalindrome(string s)
{

    var set = new HashSet<char>();
    var maxLength = 0;

    foreach (var c in s)
    {
        if (set.Contains(c))
        {
            set.Remove(c);
            maxLength += 2;
        }
        else
            set.Add(c);
    }

    return set.Count > 0 ? maxLength + 1 : maxLength;

}