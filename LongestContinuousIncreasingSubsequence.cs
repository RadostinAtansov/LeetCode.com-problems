
//Given an unsorted array of integers nums, return the length of the longest continuous increasing subsequence (i.e. subarray). The subsequence must be strictly increasing.

//A continuous increasing subsequence is defined by two indices l and r (l < r) such that it is [nums[l], nums[l + 1], ..., nums[r - 1], nums[r]] and for each l <= i < r, nums[i] < nums[i + 1].



//Example 1:
int[] nums1 = { 1, 3, 5, 4, 7 };
//Output: 3
//Explanation: The longest continuous increasing subsequence is [1, 3, 5] with length 3.
//Even though[1, 3, 5, 7] is an increasing subsequence, it is not continuous as elements 5 and 7 are separated by element
//4.

//Example 2:
int[] nums2 = {2, 2, 2, 2, 2};
//Output: 1
//Explanation: The longest continuous increasing subsequence is [2] with length 1.Note that it must be strictly


int[] test = { 1, 3, 5, 4, 2, 3, 4, 5 };
int[] test2 = { 1334, 1500, 4169, 724, -3522, 4358, 1962, -536, 705, 3145, -1719, 1827, 4961, -4509, -2005, -3058, -173, 436, -2609, -396, -1098, -4847, -4708, -2618, 2421, 3716, 4718, 4895, 447, -3274, -229, -3462, -3131, 4912, 667, 1299, 2035, 4894, 3703, -1189, -3678, -4667, 2673, -336, 141, 2711, 3253, 1868, 547, 2644, -2338, -2243, -4963, -2141, 3723, 4741, 2529, -4222, -2684, -1965, -2810, -3158, -4712, -4894, 4040, 3942, 4264, -2352, 2446, -1195, 890, 1729, -630, 350, 6, -3899, -607, -1452, 4629, -2377, -916, 4954, 3756, -3160, -34, 2376, -1069, 1308, 1944, -2561, -374, -3677, 537, -3462, 1118, -2918, -2071, 1541, -167, -3885, -361, 4658, -2296, 4930, -1023, -2694, -3327, -2614, 21, 3745, 1924, 4072, 1270, 829, 1777, 573, 97, 1512, -1014, -1710, 4161, 3636, -2645, -233, -1345, 574, -969, -2948, 2350, -3850, 1941, -3276, -1034, -1570, -3893, -4809, 3007, -3663, 457, -2713, 2753, -4617, -55, 3909, -2791, 4758, -779, 3588, 1422, -54, 2506, -1970, 1413, 4168, -4100, -2409, 3762, -3345, 2410, 1359 };

Console.WriteLine(FindLengthOfLCIS(test2));

static int FindLengthOfLCIS(int[] nums)
{
    int N = nums.Length;
    int count = 1;
    int maxLCISLength = 1;
    for (int i = 1; i < N; i++)
    {
        if (nums[i] > nums[i - 1])
        {
            count++;
            maxLCISLength = Math.Max(count, maxLCISLength);
        }
        else
        {
            count = 1;
        }
    }
    return maxLCISLength;
}