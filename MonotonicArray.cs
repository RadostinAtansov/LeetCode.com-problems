//An array is monotonic if it is either monotone increasing or monotone decreasing.

//An array nums is monotone increasing if for all i <= j, nums[i] <= nums[j]. An array nums is monotone decreasing if for all i <= j, nums[i] >= nums[j].

//Given an integer array nums, return true if the given array is monotonic, or false otherwise.



//Example 1:

int[] nums1 = { 1, 2, 2, 3 };
//Output: true
//Example 2:

int[] nums2 = {6, 5, 4, 4 };
//Output: true
//Example 3:

int[] nums3 = { 1, 3, 2 };
//Output: false

Console.WriteLine(IsMonotonic(nums3));

static bool IsMonotonic(int[] nums)
{

	bool isIncreasing = true;
	bool isDecreasing = true;

    for (int i = 0; i < nums.Length - 1; i++)
	{
		int num1 = nums[i];
		int num2 = nums[i + 1];
        if (!(num1 <= num2))
		{
			isIncreasing = false;
		}

	}

    for (int i = 0; i < nums.Length - 1; i++)
    {
        int num1 = nums[i];
        int num2 = nums[i + 1];
        if (!(num1 >= num2))
        {
            isDecreasing = false;
        }

    }

    return isIncreasing == true ? true : isDecreasing == true ? true : false;
}