


//Given an array nums of n integers where nums[i] is in the range[1, n],
//return an array of all the integers in the range [1, n] that do not appear in nums.



//Example 1:
int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
//Output: [5,6]

//Example 2:
int[] nums2 = { 1, 1 };
//Output: [2]

Console.WriteLine(string.Join(",", FindDisappearedNumbers(nums1)));

static IList<int> FindDisappearedNumbers(int[] nums)
{
    List<int> result = new List<int>();
    int maxMumber = nums.Max();
    int counter = 1;

    while (counter <= nums.Length)
    {
        if (!nums.Contains(counter))
        {
            result.Add(counter);
        }
        counter++;
    }
    return result;

}