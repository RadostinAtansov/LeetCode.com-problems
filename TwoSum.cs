

int[] nums1 = { 2, 7, 11, 15 };
int[] nums2 = { 3, 2, 4 };
int[] nums3 = { 3, 3 };
int target1 = 9;
int target2 = 6;
int target3 = 6;


var result = TwoSum(nums2, target2);

static int[] TwoSum(int[] nums, int target)
{
    int[] result = new int[2];

    for (int i = 0; i < nums.Length - 1; i++)
    {
        for (int l = i; l < nums.Length - 1; l++)
        {
            if (nums[i] + nums[l + 1] == target)
            {
                result[0] = i;
                result[1] = l + 1;
            }
        }
    }
    GC.Collect();
    return result;
}



System.Console.WriteLine($"[{result[0]}, {result[1]}]");

