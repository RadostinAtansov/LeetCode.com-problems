

string str1 = "I can run";
//Output: 0
string str2 = "Hello world";
//Output: 2 Hello - World

Console.WriteLine(StringManipulation(str1));

static string StringManipulation(string str)
{

    string[] strArr = str.Split(" ");
    int countWords = 0;
    List<string> strList = new List<string>();

    for (int i = 0; i < strArr.Length; i++)
    {
        string word = strArr[i];

        if (word.Length >= 4)
        {
            char[] chAr = word.ToCharArray();
            chAr[0] = Char.ToUpper(chAr[0]);
            word = new string(chAr);
            strList.Add(word);
        }
    }

    string result = string.Join("-", strList);

    return $"{strList.Count} " + result;

}