

//Example 1:

int[] nums1 = { 3, 0, 1 };
//Output: 2
//Explanation: n = 3 since there are 3 numbers, so all numbers are in the range [0,3]. 2 is the missing number in the range since it does not appear in nums.

//Example 2:
int[] nums2 = { 0, 1 };
//Output: 2
//Explanation: n = 2 since there are 2 numbers, so all numbers are in the range [0,2]. 2 is the missing number in the range since it does not appear in nums.

//Example 3:
int[] nums3 = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
//Output: 8
//Explanation: n = 9 since there are 9 numbers, so all numbers are in the range [0,9]. 8 is the missing number in the range since it does not appear in nums.

Console.WriteLine(MissingNumber(nums3));

static int MissingNumber(int[] nums)
{

	for (int i = 0; i < nums.Length; i++)
	{
		if (!nums.Contains(i))
		{
			return i;
		}
	}

    return nums.Length;



    //int sum = nums.Sum();
    //int n = nums.Length;
    //int s = 0;

    //for (int i = 1; i <= n; i++)      ====> faster
    //{
    //    s += i;
    //}

    //return s - sum;
}