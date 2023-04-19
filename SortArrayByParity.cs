


//Given an integer array nums, move all the even integers at the beginning of the array followed by all the odd integers.

//Return any array that satisfies this condition.



//Example 1:

int[] nums1 = { 3, 1, 2, 4 };
//Output: [2,4,3,1]
//Explanation: The outputs[4, 2, 3, 1], [2, 4, 1, 3], and[4, 2, 1, 3] would also be accepted.
//Example 2:

int[] nums2 = { 0 };
//Output: [0]

Console.WriteLine(String.Join(", ", SortArrayByParity(nums2)));

static int[] SortArrayByParity(int[] nums)
{
	var even = nums.Where(x => x % 2 == 0).ToArray();
	var odd = nums.Where(x => x % 2 != 0).ToArray();
	List<int> result = new List<int>();
	result.AddRange(even);
	result.AddRange(odd);
	

    return result.ToArray();
}