//Alice and Bob have a different total number of candies. You are given two integer arrays aliceSizes and bobSizes where aliceSizes[i] is the number of candies of the ith box of candy that Alice has and bobSizes[j] is the number of candies of the jth box of candy that Bob has.

//Since they are friends, they would like to exchange one candy box each so that after the exchange, they both have the same total amount of candy. The total amount of candy a person has is the sum of the number of candies in each box they have.

//Return an integer array answer where answer[0] is the number of candies in the box that Alice must exchange, and answer[1] is the number of candies in the box that Bob must exchange. If there are multiple answers, you may return any one of them. It is guaranteed that at least one answer exists.



//Example 1:

int[] aliceSizes1 = { 1, 1 }, bobSizes1 = { 2, 2 };
//Output: [1,2]
//Example 2:

int[] aliceSizes2 = { 1, 2 }, bobSizes2 = { 2, 3 };
//Output: [1,2]
//Example 3:

int[] aliceSizes3 = { 2 }, bobSizes3 = { 1, 3 };
//Output: [2,3]

Console.WriteLine(String.Join(", ", FairCandySwap(aliceSizes3, bobSizes3)));

static int[] FairCandySwap(int[] aliceSizes, int[] bobSizes)
{
    //int[] result = new int[2];

    //int firstSumAlice = aliceSizes.Sum();
    //int firstSumBob = bobSizes.Sum();

    //for (int a = 0; a < aliceSizes.Length; a++)
    //{
    //    int boxCandiesAlice = aliceSizes[a];

    //    for (int b = 0; b < bobSizes.Length; b++)
    //    {
    //        int boxCandiesBob = bobSizes[b];
    //        firstSumAlice -= boxCandiesAlice;
    //        firstSumAlice += boxCandiesBob;
    //        firstSumBob -= boxCandiesBob;
    //        firstSumBob += boxCandiesAlice;

    //        if (firstSumAlice == firstSumBob)
    //        {
    //            result[0] = boxCandiesAlice;
    //            result[1] = boxCandiesBob;
    //            return result;
    //        }
    //        else
    //        {
    //            firstSumAlice -= boxCandiesBob;
    //            firstSumBob += boxCandiesBob;
    //            firstSumBob -= boxCandiesAlice;
    //            firstSumAlice += boxCandiesAlice;
    //        }

    //    }

    //}

    //return result;



    int sumA = 0;
    int sumB = 0;
    foreach (int item in aliceSizes)
    {
        sumA += item;
    }
    HashSet<int> set = new HashSet<int>();
    foreach (int item in bobSizes)
    {
        set.Add(item);
        sumB += item;                                                       // =======>   95% faster
    }
    int half = (sumB - sumA) / 2;
    foreach (int item in aliceSizes)
    {
        if (set.Contains(item + half))
        {
            return new int[] { item, item + half };
        }
    }
    return new int[] { 0, 0 };
}