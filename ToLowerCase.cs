//Given a string s, return the string after replacing every uppercase letter with the same lowercase letter.



//Example 1:
string s1 = "Hello";
//Output: "hello"

//Example 2:
string s2 = "here";
//Output: "here"

string s3 = "LOVELY";
//Output: "lovely"

Console.WriteLine(ToLowerCase(s1));


static string ToLowerCase(string s)
{

    return s.ToLower();
}
