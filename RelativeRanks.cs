

//You are given an integer array score of size n, where score[i] is the score of the ith athlete in a competition. All the scores are guaranteed to be unique.

//The athletes are placed based on their scores, where the 1st place athlete has the highest score, the 2nd place athlete has the 2nd highest score, and so on. The placement of each athlete determines their rank:

//The 1st place athlete's rank is "Gold Medal".
//The 2nd place athlete's rank is "Silver Medal".
//The 3rd place athlete's rank is "Bronze Medal".
//For the 4th place to the nth place athlete, their rank is their placement number (i.e., the xth place athlete's rank is "x").
//Return an array answer of size n where answer[i] is the rank of the ith athlete.



//Example 1:
int[] score1 = { 5, 4, 3, 2, 1 };
//Output: ["Gold Medal","Silver Medal","Bronze Medal","4","5"]
//Explanation: The placements are[1st, 2nd, 3rd, 4th, 5th].

//Example 2:
int[] score2 = { 10, 3, 8, 9, 4 };
//Output: ["Gold Medal","5","Bronze Medal","Silver Medal","4"]
//Explanation: The placements are[1st, 5th, 3rd, 2nd, 4th].

Console.WriteLine(String.Join(',', FindRelativeRanks(score2)));

static string[] FindRelativeRanks(int[] score)
{
    string firstPlace = "Gold Medal";
    string secondPlace = "Silver Medal";
    string thirthPlace = "Bronze Medal";
    string[] result = new string[score.Length];
    int counter = 0;

    for (int i = 0; i < score.Length; i++)
    {
        counter++;
        int hightestScore = score.Max();
        var asenchu = Array.IndexOf(score, hightestScore);

        switch (counter)
        {
           case 1 : result[asenchu] = firstPlace;
                break;
            case 2 : result[asenchu] = secondPlace;
                break;
            case 3 : result[asenchu] = thirthPlace;
                break;
            default : result[asenchu] = counter.ToString();
                break;
        };

    score[asenchu] = -1;
    }

    return result;
}