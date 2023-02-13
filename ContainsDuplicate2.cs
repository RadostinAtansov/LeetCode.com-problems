

//Example 1:
int[] nums1 = { 1, 2, 3, 1 };
int k1 = 3;
//Output: true

//Example 2:
int[] nums2 = { 1, 0, 1, 1 };
int k2 = 1;
//Output: true

//Example 3:
int[] nums3 = { 1, 2, 3, 1, 2, 3 }; 
int k3 = 2;
//Output: false

Console.WriteLine(ContainsNearbyDuplicate(nums1, k1));

static bool ContainsNearbyDuplicate(int[] nums, int k)
{

    var dictionary = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++)
    {
        if (!dictionary.TryAdd(nums[i], i))
        {
            if (Math.Abs(i - dictionary[nums[i]]) <= k)
            {
                return true;
            }

            dictionary[nums[i]] = i;
        }
    }

    return false;
}