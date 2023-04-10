


//You are given a string s of lowercase English letters and an array widths denoting how many pixels wide each lowercase English letter is. Specifically, widths[0] is the width of 'a', widths[1] is the width of 'b', and so on.

//You are trying to write s across several lines, where each line is no longer than 100 pixels. Starting at the beginning of s, write as many letters on the first line such that the total width does not exceed 100 pixels. Then, from where you stopped in s, continue writing as many letters as you can on the second line. Continue this process until you have written all of s.

//Return an array result of length 2 where:

//result[0] is the total number of lines.
//result[1] is the width of the last line in pixels.


//Example 1:
int[] widths1 = { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
string s1 = "abcdefghijklmnopqrstuvwxyz";
//Output: [3,60]
//Explanation: You can write s as follows:
//abcdefghij  // 100 pixels wide
//klmnopqrst  // 100 pixels wide
//uvwxyz      // 60 pixels wide
//There are a total of 3 lines, and the last line is 60 pixels wide.

//Example 2:
int[] widths2 = { 4, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
string s2 = "bbbcccdddaaa";
//Output: [2,4]
//Explanation: You can write s as follows:
//bbbcccdddaa  // 98 pixels wide
//a            // 4 pixels wide
//There are a total of 2 lines, and the last line is 4 pixels wide.


int[] widths3 = { 3, 4, 10, 4, 8, 7, 3, 3, 4, 9, 8, 2, 9, 6, 2, 8, 4, 9, 9, 10, 2, 4, 9, 10, 8, 2 };
string s3 = "mqblbtpvicqhbrejb";

Console.WriteLine(string.Join(',', NumberOfLines(widths1, s1)));

static int[] NumberOfLines(int[] widths, string s)
{
    int result = 0;
    int lines = 1;

    Dictionary<char, int> alphabet = new Dictionary<char, int>()
    {
        { 'a', widths[0] },
        { 'b', widths[1] },
        { 'c', widths[2] },
        { 'd', widths[3] },
        { 'e', widths[4] },
        { 'f', widths[5] },
        { 'g', widths[6] },
        { 'h', widths[7] },
        { 'i', widths[8] },
        { 'j', widths[9] },
        { 'k', widths[10] },
        { 'l', widths[11] },
        { 'm', widths[12] },
        { 'n', widths[13] },
        { 'o', widths[14] },
        { 'p', widths[15] },
        { 'q', widths[16] },
        { 'r', widths[17] },
        { 's', widths[18] },
        { 't', widths[19] },
        { 'u', widths[20] },
        { 'v', widths[21] },
        { 'w', widths[22] },
        { 'x', widths[23] },
        { 'y', widths[24] },
        { 'z', widths[25] },
    };

    for (int i = 0; i < s.Length; i++)
    {
        result += alphabet[s[i]];

        if (result == 100 && s.Length == i)
        {
            lines++;
            result = 0;
        }
        else if (result > 100)
        {
            lines++;
            result -= alphabet[s[i]];
            result = 0;
            i--;
        }

    }

    return new int[] { lines, result};
}