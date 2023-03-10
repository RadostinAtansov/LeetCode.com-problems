

//You are given a license key represented as a string s that consists of only alphanumeric characters and dashes. The string is separated into n + 1 groups by n dashes. You are also given an integer k.

//We want to reformat the string s such that each group contains exactly k characters, except for the first group, which could be shorter than k but still must contain at least one character. Furthermore, there must be a dash inserted between two groups, and you should convert all lowercase letters to uppercase.

//Return the reformatted license key.



//Example 1:
string s1 = "5F3Z-2e-9-w";
int k1 = 4;
//Output: "5F3Z-2E9W"
//Explanation: The string s has been split into two parts, each part has 4 characters.
//Note that the two extra dashes are not needed and can be removed.

//Example 2:
string s2 = "2-5g-3-J";
int k2 = 2;
//Output: "2-5G-3J"
//Explanation: The string s has been split into three parts, each part has 2 characters except the first part as it could be shorter as mentioned above.


string s3 = "2-5g-3-Jfeqerte1f";
int k3 = 4;

Console.WriteLine(LicenseKeyFormatting(s1, k1));

static string LicenseKeyFormatting(string s, int k)
{
    string[] strWithoutDashes = s.Split('-', StringSplitOptions.RemoveEmptyEntries);
    string str = String.Concat(strWithoutDashes);
    int length = str.Length;
    int reminder = str.Length % k;
    List<char> list = new List<char>();
    int counter = 0;

    if (length % k == 0)
    {
        for (int i = 0; i < str.Length; i++)
        {
            var ch = char.ToUpper(str[i]);
            if(i % k == 0 && i != 0)
            {
                list.Add('-');
                list.Add(ch);
            }
            else
            {
                list.Add(ch);
                counter++;
            }
        }
    }
    //Example 2:
    //string s2 = "2-5g-3-J";
    //int k2 = 2;
    //Output: "2-5G-3J"
    else
    {
        int counterK = 0;
        for (int i = 0; i < str.Length; i++)
        {
            var ch = char.ToUpper(str[i]);
            if (counter == reminder)
            {
                list.Add('-');
                counterK = 0;
                counter++;
                i--;
            }
            else if (counterK == k && i != 0)
            {
                list.Add('-');
                counterK = 0;
                i--;
            }
            else
            {
                list.Add(ch);
                counter++;
                counterK++;
            }
        }
        
    }
    Console.WriteLine(String.Join("", list));
    return string.Empty;
}