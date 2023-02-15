


//Example 1:
int[] nums1 = { 0, 1, 0, 3, 12 };
//Output: [1,3,12,0,0]

//Example 2:
int[] nums2 = { 0 };
//Output: [0]


int[] nums3 = { 0, 0, 1 };
int[] nums4 = { 1, 0, 0 };
int[] nums5 = { 0, 1, 0, 1 };
int[] nums6 = { 1, 0, 0, 1 };

MoveZeroes(nums1);

static void MoveZeroes(int[] nums)
{
    int lastEle = 0, curEle = 0;

    while (curEle < nums.Length)
    {
        if (nums[curEle] != 0)
        {
            int temp = nums[curEle];
            nums[curEle] = nums[lastEle];
            nums[lastEle] = temp;
            lastEle++;
        }
        curEle++;
    }

    Console.WriteLine($"[{string.Join(",", nums)}]");
}