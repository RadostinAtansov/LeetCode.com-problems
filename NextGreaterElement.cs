

//The next greater element of some element x in an array is the first greater element that is to the right of x in the same array.

//You are given two distinct 0-indexed integer arrays nums1 and nums2, where nums1 is a subset of nums2.

//For each 0 <= i < nums1.length, find the index j such that nums1[i] == nums2[j] and determine the next greater element of nums2[j] in nums2.If there is no next greater element, then the answer for this query is -1.

//Return an array ans of length nums1.length such that ans[i] is the next greater element as described above.



//Example 1:
int[] nums11 = { 4, 1, 2 };
int[] nums12 = { 1, 3, 4, 2 };
//Explanation: The next greater element for each value of nums1 is as follows:
//-4 is underlined in nums2 = [1, 3, 4, 2].There is no next greater element, so the answer is -1.
//- 1 is underlined in nums2 = [1,3,4,2]. The next greater element is 3.
//- 2 is underlined in nums2 = [1,3,4,2]. There is no next greater element, so the answer is -1.

//Example 2:
int[] nums21 = {2, 4};
int[] nums22 = {1, 2, 3, 4};
//Output: [3,-1]
//Explanation: The next greater element for each value of nums1 is as follows:
//-2 is underlined in nums2 = [1, 2, 3, 4].The next greater element is 3.
//- 4 is underlined in nums2 = [1,2,3,4]. There is no next greater element, so the answer is -1.

int[] nums1 = { 1, 3, 5, 2, 4 };
int[] nums2 = { 6, 5, 4, 3, 2, 1, 7 };


Console.WriteLine(String.Join(',', NextGreaterElement(nums1, nums2)));

static int[] NextGreaterElement(int[] nums1, int[] nums2)
{
	int[] result = new int[nums1.Length];
	int counter = 0;

	for (int i = 0; i < nums1.Length; i++)
	{
		if (nums2.Contains(nums1[i]))
		{
			int pos = Array.IndexOf(nums2, nums1[i]);
			for (int j = pos; j < nums2.Length; j++)
			{
				if (nums1[i] < nums2[j])
				{
					result[counter++] = nums2[j];
					break;
				}
				else if (result[counter] == 0 && j == nums2.Length - 1)
				{
                    result[counter++] = -1;
                }
                
			}

		}
	}


    return result;
}