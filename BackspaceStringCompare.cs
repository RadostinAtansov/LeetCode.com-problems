//Given two strings s and t, return true if they are equal when both are typed into empty text editors. '#' means a backspace character.

//Note that after backspacing an empty text, the text will continue empty.



//Example 1:

string s1 = "ab#c", t1 = "ad#c";
//Output: true
//Explanation: Both s and t become "ac".
//Example 2:

string s2 = "ab##", t2 = "c#d#";
//Output: true
//Explanation: Both s and t become "".
//Example 3:

string s3 = "a#c", t3 = "b";
//Output: false
//Explanation: s becomes "c" while t becomes "b".

string s4 = "y#fo##f", t4 = "y#f#o##f";


Console.WriteLine(BackspaceCompare(s3, t3));

static bool BackspaceCompare(string s, string t)
{
	
	for (int i = 0; i < s.Length; i++)
	{
		if (i == 0 && s[i] == '#')
		{
			continue;
		}
		if (s[i] == '#')
		{
			s = s.Remove(i - 1, 2);
			i -= 2;
		}
	}
    for (int i = 0; i < t.Length; i++)
    {
        if (i == 0 && t[i] == '#')
        {
            continue;
        }
        if (t[i] == '#')
        {
            t = t.Remove(i - 1, 2);
			i-=2;
        }
    }

	var s2 = s.Where(s => s != '#').ToArray();
	var t2 = t.Where(t => t != '#').ToArray();

    var newS = new string(s2);
    var newT = new string(t2);

    if (newS == newT)
	{
		return true;
	}

    return false;
}