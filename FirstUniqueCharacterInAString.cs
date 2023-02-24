


//Example 1:
string s1 = "leetcode";
//Output: 0

//Example 2:
string s2 = "loveleetcode";
//Output: 2

//Example 3:
string s3 = "aabb";
//Output: -1


Console.WriteLine(FirstUniqChar(s3));

static int FirstUniqChar(string s)
{
    //List<char> list = new List<char>(s);
    //List<char> listS = new List<char>(s);

    //for (int i = 0; i < listS.Count; i++)
    //{
    //    char c = listS[i];
    //    list.Remove(c);
    //    if (!list.Contains(c))
    //    {
    //        return i;
    //    }
    //    list.Add(c);
    //}

    //return -1;



    var cMap = new nint[26]; // nint why not, would totally make it unsafe for stackalloc and speed if leetcode allowed it
    foreach (var c in s)
    {
        cMap[c - 'a']++;
    }

    for (var i = 0; i < s.Length; i++)                                 //=======> faster
    {
        var c = s[i];
        if (cMap[c - 'a'] == 1)
            return i;
    }

    return -1;
}