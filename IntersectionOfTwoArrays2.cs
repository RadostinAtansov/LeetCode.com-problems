


//Example 1:
int[] nums11 = { 1, 2, 2, 1 }, nums21 = { 2, 2 };
//Output: [2,2] all numbers from two arrays

//Example 2:
int[] nums12 = { 4, 9, 5 }, nums22 = { 9, 4, 9, 8, 4 };
//Output: [9,4]
//Explanation: [4,9] is also accepted.

var result = Intersection(nums11, nums21);

Console.WriteLine(String.Join(",", result));

static int[] Intersection(int[] nums1, int[] nums2)
{
    List<int> result = new List<int>();

    nums1 = nums1.ToArray();
    nums2 = nums2.ToArray();

    for (int i = 0; i < nums1.Length; i++)
    {
        int resN = nums1[i];
        if (nums2.Contains(resN))
        {
            result.Add(resN);
        }
    }

    return result.ToArray();
}
