


//Given an integer array nums, return the third distinct maximum number in this array. If the third maximum does not exist, return the maximum number.



//Example 1:
int[] nums1 = { 3, 2, 1 };
//Output: 1
//Explanation:
//The first distinct maximum is 3.
//The second distinct maximum is 2.
//The third distinct maximum is 1.

//Example 2:
int[] nums2 = { 1, 2 };
//Output: 2
//Explanation:
//The first distinct maximum is 2.
//The second distinct maximum is 1.
//The third distinct maximum does not exist, so the maximum (2) is returned instead.

//Example 3:
int[] nums3 = { 2, 2, 3, 1 };
//Output: 1
//Explanation:
//The first distinct maximum is 3.
//The second distinct maximum is 2 (both 2's are counted together since they have the same value).
//The third distinct maximum is 1.

Console.WriteLine(ThirdMax(nums1));

static int ThirdMax(int[] nums)
{
    SortedSet<int> set = new SortedSet<int>(nums);  
    var distinctSet = set.ToList();

    if (distinctSet.Count >= 3)
        return distinctSet[distinctSet.Count - 3];
    else if (distinctSet.Count == 2)
        return distinctSet.Max();
    else if (distinctSet.Count == 1)
        return distinctSet[0];

    return distinctSet[distinctSet.Count - 3];
}
