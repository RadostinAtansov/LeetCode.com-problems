
int[] nums1 = { 1, 1, 2 };
//Output: 2, nums = [1,2,_]
int[] nums2 = {0,0,1,1,1,2,2,3,3,4};
//Output: 5, nums = [0, 1, 2, 3, 4, _, _, _, _, _]

int k = RemoveDuplicates(nums1);

static int RemoveDuplicates(int[] nums)
{

    int i = 1;
    foreach (int n in nums)
    {
        if (nums[i - 1] != n) nums[i++] = n; // with in-place algorithm
    }

    return i;
    
}
