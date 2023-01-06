
int[] nums1 = { 1, 3, 5, 6 };
int target1 = 5;
//Output: 2
int target2 = 2;
//Output: 1
int target3 = 7;
//Output: 4
int[] nums2 = { 1 };


Console.WriteLine(SearchInsert(nums2, 0));

static int SearchInsert(int[] nums, int target)
{
	int[] resultSeq = nums.Where(s => s.Equals(target)).ToArray();
	if (resultSeq.Length > 0)
	{
		for (int i = 0; i < nums.Length; i++)
		{
			if (nums[i] == target)
			{
				return i;
			}
		}
			
	}
	else if (resultSeq.Length == 0)
	{
		for (int i = 0; i < nums.Length; i++)
		{
			if (target < nums[i])
			{
				return i;
			}
		}
	}

    return nums.Length;
}