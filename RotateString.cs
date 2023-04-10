//Given two strings s and goal, return true if and only if s can become goal after some number of shifts on s.

//A shift on s consists of moving the leftmost character of s to the rightmost position.

//For example, if s = "abcde", then it will be "bcdea" after one shift.


//Example 1:
string s1 = "abcde", goal1 = "cdeab";
//Output: true

//Example 2:
string s2 = "abcde", goal2 = "abced";
//Output: false

Console.WriteLine(RotateString(s2, goal2));

static bool RotateString(string s, string goal)
{
    int length = s.Length;
    char[] sCharArr = s.ToCharArray();


    for (int i = 0; i < length; i++)
    {
        for (int l = 0; l < sCharArr.Length - 1; l++)
        {
            char moveForward = sCharArr[l];
            char moveBack = sCharArr[l + 1];

            sCharArr[l + 1] = moveForward;
            sCharArr[l] = moveBack;
        }

        string newStr = new string(sCharArr);

        if (newStr == goal)
        {
            return true;
        }
    }

    return false;
}