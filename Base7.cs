



//Given an integer num, return a string of its base 7 representation.



//Example 1:
int num1 = 100;
//Output: "202"

//Example 2:
int num2 = -7;
//Output: "-10"

Console.WriteLine(ConvertToBase7(-7));

static string ConvertToBase7(int num)
{
	string result = string.Empty;
	bool flag = false;
	if (num < 7 && num > -7)
	{
		return (num % 7).ToString();
	}
    if (num <= -7)
	{
		num = Math.Abs(num);
		flag = true;
	}

	while (num >= 7)
	{
		int wholeNumber = num / 7;
		int reminderNumber = num % 7;

		if (reminderNumber < 7)
		{
			result += reminderNumber;
		}
		if(wholeNumber < 7)
		{
			result += wholeNumber;
		}
		num = wholeNumber;
	}

	if (flag == true)
	{
		result += '-';
	}

	char[] charArray = result.ToCharArray();
	Array.Reverse(charArray);

    return new string(charArray);
}