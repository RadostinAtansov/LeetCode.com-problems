

//Given a binary array nums, return the maximum number of consecutive 1's in the array.



//Example 1:
int[] nums1 = { 1, 1, 0, 1, 1, 1 };
//Output: 3
//Explanation: The first two digits or the last three digits are consecutive 1s. The maximum number of consecutive 1s is 3.

//Example 2:
int[] nums2 = { 1, 0, 1, 1, 0, 1 };
//Output: 2

Console.WriteLine(FindMaxConsecutiveOnes(nums2));

static int FindMaxConsecutiveOnes(int[] nums)
{
	int counter = 0;
	int temp = 0;

	for (int i = 0; i < nums.Length; i++)
	{
		if (nums[i] == 1)
		{
			counter++;
			if (counter > temp)
			{
				temp = counter;
			}
		}
		else
		{
			counter = 0;
		}
	}

    return temp;
}