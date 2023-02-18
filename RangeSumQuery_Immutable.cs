

//Example 1:

//Input
//["NumArray", "sumRange", "sumRange", "sumRange"]

//Output
//[null, 1, -1, -3]

//Explanation
//NumArray numArray = new NumArray([-2, 0, 3, -5, 2, -1]);
//numArray.sumRange(0, 2); // return (-2) + 0 + 3 = 1
//numArray.sumRange(2, 5); // return 3 + (-5) + 2 + (-1) = -1
//numArray.sumRange(0, 5); // return (-2) + 0 + 3 + (-5) + 2 + (-1) = -3

public class NumArray
{
	private int[] nums;

	public NumArray(int[] nums)
	{
		this.nums = nums;
	}


    public int SumRange(int left, int right)
    {
		int sum = 0;

		for (int i = left; i <= right; i++)
		{
			sum += this.nums[i];
		}

        return sum;
    }

}