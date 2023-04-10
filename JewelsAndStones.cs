

//You 're given strings jewels representing the types of stones that are jewels, and stones representing the stones you have. Each character in stones is a type of stone you have. You want to know how many of the stones you have are also jewels.

//Letters are case sensitive, so "a" is considered a different type of stone from "A".



//Example 1:
string jewels1 = "aA", stones1 = "aAAbbbb";
//Output: 3

//Example 2:
string jewels2 = "z", stones2 = "ZZ";
//Output: 0

Console.WriteLine(NumJewelsInStones(jewels1, stones1));

static int NumJewelsInStones(string jewels, string stones)
{
    int countJewels = 0;

    for (int i = 0; i < jewels.Length; i++)
    {
        for (int l = 0; l < stones.Length; l++)
        {
            if (jewels[i] == stones[l])
            {
                countJewels++;
            }
        }
    }


    return countJewels;
}