

int[] nums1 = { 2, 2, 1 };
//Output: 1

int[] nums2 = { 4, 1, 2, 1, 2 };
//Output: 4

int[] nums3 = { 1 };
//Output: 1

Console.WriteLine(SingleNumber(nums2));

static int SingleNumber(int[] nums)
{
	int result = 0;

	for (int i = 0; i < nums.Length; i++)
	{
		result = result ^ nums[i];
	}

	//int count = 0;
	//int result = 0;

	//for (int i = 0; i < nums.Length; i++)
	//{

	//	for (int l = 0; l < nums.Length; l++)
	//	{
	//		if (nums[i] == nums[l])
	//		{
	//			count++;
	//		}
	//	}

	//	result = nums[i];

	//	if (count == 1)
	//	{
	//		break;
	//	}
	//	count = 0;
	//}

    return result;
}