//Given an array of integers nums, half of the integers in nums are odd, and the other half are even.

//Sort the array so that whenever nums[i] is odd, i is odd, and whenever nums[i] is even, i is even.

//Return any answer array that satisfies this condition.



//Example 1:
int[] nums1 = { 4, 2, 5, 7 };
//Output: [4,5,2,7]
//Explanation: [4,7,2,5], [2,5,4,7], [2,7,4,5] would also have been accepted.

//Example 2:
int[] nums2 = { 2, 3 };
//Output: [2,3]

Console.WriteLine(String.Join(", ", SortArrayByParityII(nums2)));

static int[] SortArrayByParityII(int[] nums)
{
    var evenNumbers = nums.Where(x => x % 2 == 0).ToArray();
    var oddNumbers = nums.Where(x => x % 2 != 0).ToArray();
    int[] result = new int[nums.Length];
    int evenIndex = 0;
    int oddIndex = 0;

    for (int i = 0; i < result.Length; i++)
    {
        if (evenNumbers.Length != evenIndex && i % 2 == 0)
        {
            result[i] = evenNumbers[evenIndex];
            evenIndex++;
        }
        else if (oddNumbers.Length != oddIndex && i % 2 != 0)
        {
            result[i] = oddNumbers[oddIndex];
            oddIndex++;
        }
    }

    return result;
}