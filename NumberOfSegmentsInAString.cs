

//Given a string s, return the number of segments in the string.

//A segment is defined to be a contiguous sequence of non-space characters.

//Example 1:
string s1 = "Hello, my name is John";
//Output: 5
//Explanation: The five segments are["Hello,", "my", "name", "is", "John"]

//Example 2:
string s2 = "Hello";
//Output: 1

Console.WriteLine(CountSegments("Of all the gin joints in all the towns in all the world,   "));

static int CountSegments(string s)
{
    return  s.Split(" ", StringSplitOptions.RemoveEmptyEntries).Length == 0 
            ? 0 
            : s.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray().Length;
}