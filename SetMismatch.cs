

//You have a set of integers s, which originally contains all the numbers from 1 to n. Unfortunately, due to some error, one of the numbers in s got duplicated to another number in the set, which results in repetition of one number and loss of another number.

//You are given an integer array nums representing the data status of this set after the error.

//Find the number that occurs twice and the number that is missing and return them in the form of an array.



//Example 1:
int[] nums1 = { 1, 2, 2, 4 };
//Output: [2,3]

//Example 2:
int[] nums2 = { 1, 1 };
//Output: [1,2]


int[] nums3 = { 3, 2, 2, 3 };



Console.WriteLine(string.Join(",", FindErrorNums(nums3)));

static int[] FindErrorNums(int[] nums)
{
    HashSet<int> hashset = new HashSet<int>();
    int[] result = new int[2];
    for (int i = 0; i < nums.Length; i++)
    {
        if (!hashset.Add(nums[i]))
        {
            result[0] = nums[i];
        }
    }
    for (int i = 1; i <= 10000; i++)
    {
        if (!hashset.Contains(i))
        {
            result[1] = i;
            break;
        }
    }
    return result;

}