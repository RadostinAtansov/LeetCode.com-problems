

//Example 1:

int[] nums1 = { 0, 1, 2, 4, 5, 7 };
//Output: ["0->2","4->5","7"]
//Explanation: The ranges are:
//[0,2] --> "0->2"
//[4, 5]-- > "4->5"
//[7, 7]-- > "7"

//Example 2:

int[] nums2 = { 0, 2, 3, 4, 6, 8, 9 };
//Output: ["0","2->4","6","8->9"]
//Explanation: The ranges are:
//[0,0] --> "0"
//[2, 4]-- > "2->4"
//[6, 6]-- > "6"
//[8, 9]-- > "8->9"

int[] nums3 = { -1 };
int[] nums4 = {  };


var list = SummaryRanges(nums3);

Console.WriteLine($"[{string.Join(",", list)}]");

static IList<string> SummaryRanges(int[] nums)
{

	if (nums.Length == 0)
	{
        return new List<string>();
    }
    if (nums[0] == -1)
	{
		return new List<string>() { "-1" };
	}

	string output = $"[{0}][{1}] ---> \"{0}->{1}\"";
	List<int> rangesNumbers = new List<int>();
	List<string> ranges = new List<string>();
    int nexNum = 0;
	int count = 0;

    for (int i = 0; i < nums.Length; i++)
	{
		int num = nums[i];

        if (i != nums.Length - 1)
		{
			nexNum = nums[i + 1];
		}

        if (num + 1 == nexNum)
		{
			rangesNumbers.Add(num);
			count++;
		}
        else if (num + 1 != nexNum)
		{
			if (num + 1 != nexNum && count == 0)
			{
				output = $"{num}";
                ranges.Add(output);
				continue;
            }
            rangesNumbers.Add(num);
            output = $"{rangesNumbers[0]}->{rangesNumbers[rangesNumbers.Count - 1]}";
			ranges.Add(output);
            rangesNumbers.Clear();
			count = 0;
		}

	}

    return ranges;

    //List<string> result = new List<string>();
    //int p = 0;
    //for (int i = 1; i < nums.Length; i++)
    //{
    //    if (Math.Abs(nums[i] - nums[i - 1]) > 1)
    //    {
    //        if (i - 1 == p) result.Add($"{nums[p]}");
    //        else result.Add($"{nums[p]}->{nums[i - 1]}");                                                        =====> faster
    //        p = i;
    //    }
    //}
    //if (p == nums.Length - 1) result.Add($"{nums[p]}");
    //else if (p < nums.Length - 1) result.Add($"{nums[p]}->{nums[nums.Length - 1]}");
    //return result;
}