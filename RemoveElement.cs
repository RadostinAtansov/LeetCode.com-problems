int[] nums1 = { 3, 2, 2, 3 };
int val1 = 3;
//Output: 2, nums = [2, 2, _, _]

int[] nums2 = { 0, 1, 2, 2, 3, 0, 4, 2 };
int val2 = 2;
//Output: 5, nums = [0, 1, 4, 0, 3, _, _, _]
int result = RemoveElement(nums1, val1);

Console.WriteLine(result);

static int RemoveElement(int[] nums, int val)
{
    int index = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] != val) nums[index++] = nums[i]; // in-place algorithm
    }

    return index;
}