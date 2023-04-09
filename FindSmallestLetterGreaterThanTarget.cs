


//You are given an array of characters letters that is sorted in non-decreasing order, and a character target. There are at least two different characters in letters.

//Return the smallest character in letters that is lexicographically greater than target. If such a character does not exist, return the first character in letters.

//Example 1:
char[] letters1 = { 'c', 'f', 'j' };
char target1 = 'a';
//Output: 'c'
//Explanation: The smallest character that is lexicographically greater than 'a' in letters is 'c'.

//Example 2:
char[] letters2 = { 'c', 'f', 'j'};
char target2 = 'c';
//Output: 'f'
//Explanation: The smallest character that is lexicographically greater than 'c' in letters is 'f'.

//Example 3:
char[] letters3= {'x', 'x', 'y', 'y'};
char target3 = 'z';
//Output: 'x'
//Explanation: There are no characters in letters that is lexicographically greater than 'z' so we return letters[0].

char[] test = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
char targ = 'y';

Console.WriteLine(NextGreatestLetter(test, targ));

static char NextGreatestLetter(char[] letters, char target)
{

    Dictionary<int, char> map = new Dictionary<int, char>() 
    {
        {1, 'a'},
        {2, 'b'},
        {3, 'c'},
        {4, 'd'},
        {5, 'e'},
        {6, 'f'},
        {7, 'g'},
        {8, 'h'},
        {9, 'i'},
        {10, 'j'},
        {11, 'k'},
        {12, 'l'},
        {13, 'm'},
        {14, 'n'},
        {15, 'o'},
        {16, 'p'},
        {17, 'q'},
        {18, 'r'},
        {19, 's'},
        {20, 't'},
        {21, 'u'},
        {22, 'v'},
        {23, 'w'},
        {24, 'x'},
        {25, 'y'},
        {26, 'z'},
    };

    int targetStartMap = map.FirstOrDefault(a => a.Value == target).Key;

    for (int i = targetStartMap + 1; i <= map.Count; i++)
    {

        var check = map[i];

        if (letters.Contains(check))
        {
            return check;
        }
    }

    return letters[0];
}