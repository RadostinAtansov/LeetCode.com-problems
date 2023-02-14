


//Example 1:
int num1 = 38;
//Output: 2
//Explanation: The process is
//38-- > 3 + 8-- > 11
//11-- > 1 + 1-- > 2
//Since 2 has only one digit, return it.

//Example 2:
int num2 = 0;
//Output: 0

Console.WriteLine(AddDigits(num2));

static int AddDigits(int num)
{
    int[] result = num.ToString().Select(c => (int)Char.GetNumericValue(c)).ToArray();

    while (result.Length != 1)
	{
		int resultNumbers = 0;

		if (result[0] == 0)
		{
			return 0;
		}
		for (int i = 0; i < result.Length; i++)
		{
			int number = result[i];
			resultNumbers += number;
		}
		num = resultNumbers;
        result = num.ToString().Select(c => (int)Char.GetNumericValue(c)).ToArray();
    }

    return result[0];
}