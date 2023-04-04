


//Given a non-empty array of non-negative integers nums, the degree of this array is defined as the maximum frequency of any one of its elements.

//Your task is to find the smallest possible length of a (contiguous) subarray of nums, that has the same degree as nums.


//Example 1:
int[] nums1 = { 1, 2, 2, 3, 1 };
//Output: 2
//Explanation:
//The input array has a degree of 2 because both elements 1 and 2 appear twice.
//Of the subarrays that have the same degree:
//[1, 2, 2, 3, 1], [1, 2, 2, 3], [2, 2, 3, 1], [1, 2, 2], [2, 2, 3], [2, 2]
//The shortest length is 2. So return 2.

//Example 2:
int[] nums2 = { 1, 2, 2, 3, 1, 4, 2 };
//Output: 6
//Explanation:
//The degree is 3 because the element 2 is repeated 3 times.
//So [2,2,3,1,4,2] is the shortest subarray, therefore returning 6.

Console.WriteLine(FindShortestSubArray(nums1));

static int FindShortestSubArray(int[] nums)
{
    Dictionary<int, int> degreeNumber = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        if (!degreeNumber.ContainsKey(nums[i]))
        {
            degreeNumber.Add(nums[i], 1);
        }
        else
        {
            degreeNumber[nums[i]]++;
        }
    }

    int maxDegreeNumber = degreeNumber.Values.Max();
    Dictionary<int, int> filterNumbers = degreeNumber.Where(x => x.Value == maxDegreeNumber).ToDictionary(x => x.Key, v => v.Value);
    int tempInt = int.MaxValue;

    if (filterNumbers.Count == 1)
    {
        int number = filterNumbers.First().Key;
        int firstAppear = Array.IndexOf(nums, number);
        int lastAppear = Array.LastIndexOf(nums, number);

        var subStr = nums[firstAppear..(lastAppear + 1)];

        return subStr.Length;
    }
    else
    {

        foreach (var item in filterNumbers)
        {
            int firstAppear = Array.IndexOf(nums, item.Key);
            int lastAppear = Array.LastIndexOf(nums, item.Key);

            int[] subStr = nums[firstAppear..(lastAppear + 1)];

            if (subStr.Length < tempInt)
            {
                tempInt = subStr.Length;
            }

        }
    }



    return tempInt;
}