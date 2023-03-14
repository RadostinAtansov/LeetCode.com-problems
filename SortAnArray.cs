



//Given an array of integers nums, sort the array in ascending order and return it.

//You must solve the problem without using any built-in functions in O(nlog(n)) time complexity and with the smallest space complexity possible.



//Example 1:
int[] nums1 = { 5, 2, 3, 1 };
//Output: [1,2,3,5]
//Explanation: After sorting the array, the positions of some numbers are not changed (for example, 2 and 3), while the positions of other numbers are changed (for example, 1 and 5).

//Example 2:
int[] nums2 = { 5, 1, 1, 2, 0, 0 };
//Output: [0,0,1,1,2,5]
//Explanation: Note that the values of nums are not necessairly unique.

Console.WriteLine(string.Join(',', SortArray(nums2)));

static int[] SortArray(int[] nums)
{
    // here we make the priority queue
    PriorityQueue<int, int> _sort = new PriorityQueue<int, int>();
    // here we make the output array
    int[] output = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        // here we add nums[i] to the priority queue
        _sort.Enqueue(nums[i], nums[i]);
    }
    for (int j = 0; j < nums.Length; j++)
    {
        // here we add values to the output based on the lowest priority
        output[j] = _sort.Dequeue();
    }
    return output;
}