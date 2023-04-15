


//In a string s of lowercase letters, these letters form consecutive groups of the same character.

//For example, a string like s = "abbxxxxzyy" has the groups "a", "bb", "xxxx", "z", and "yy".

//A group is identified by an interval [start, end], where start and end denote the start and end indices (inclusive) of the group. In the above example, "xxxx" has the interval [3,6].

//A group is considered large if it has 3 or more characters.

//Return the intervals of every large group sorted in increasing order by start index.


//Example 1:
string s1 = "abbxxxxzzy";
//Output: [[3,6]]
//Explanation: "xxxx" is the only large group with start index 3 and end index 6.

//Example 2:
string s2 = "abc";
//Output: []
//Explanation: We have groups "a", "b", and "c", none of which are large groups.

//Example 3:
string s3 = "abcdddeeeeaabbbcd";
//Output: [[3,5],[6,9],[12,14]]
//Explanation: The large groups are "ddd", "eeee", and "bbb".

string test = "aaa";

Console.WriteLine(LargeGroupPositions(s3));

static IList<IList<int>> LargeGroupPositions(string s)
{
    List<List<int>> listOfLists = new List<List<int>>();
    List<int> positions = new List<int>();
    int countChars = 1;
    int startPosition = 0;
    int endPositions = 0;

    for (int i = 1; i < s.Length; i++)
    {
        char previousChar = s[i - 1];
        char currentChar = s[i];

        if (previousChar == currentChar)
        {
            countChars++;
        }
        if (countChars >= 3 && previousChar != currentChar)
        {
            startPosition = i - countChars;
            endPositions = startPosition - 1 + countChars;
            positions.Add(startPosition);
            positions.Add(endPositions);
            listOfLists.Add(positions);
            countChars = 1;
            positions = new List<int>();
        }
        else if (countChars >= 3 && previousChar == currentChar && s.Length - 1 == i)
        {
            startPosition = i - (countChars - 1);
            endPositions = s.Length - 1;
            positions.Add(startPosition);
            positions.Add(endPositions);
            listOfLists.Add(positions);
        }
        else if(countChars > 1 && previousChar != currentChar)
        {
            countChars = 1;
        }

    }

    return listOfLists.ToArray();
}