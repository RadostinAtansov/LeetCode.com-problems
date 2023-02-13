

//Example 1:
int[] nums1 = { 1, 2, 3, 1 };
//Output: true

//Example 2:
int[] nums2 = { 1, 2, 3, 4 };
//Output: false

//Example 3:
int[] nums3 = {1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
//Output: true

Console.WriteLine(ContainsDuplicate(nums1));

static bool ContainsDuplicate(int[] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        int numberI = nums[i];
        for (int l = i + 1; l < nums.Length; l++)
        {
            int numberL = nums[i];
            int nexNumberL = nums[l];

            if (numberL == nexNumberL)
            {
                return true;
            }
        }
    }

    return false;
}