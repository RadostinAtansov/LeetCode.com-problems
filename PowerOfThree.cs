


//Example 1:

int n1 = 27;
//Output: true
//Explanation: 27 = 3^3
//Example 2:

int n2 = 0;
//Output: false
//Explanation: There is no x where 3x = 0.
//Example 3:

int n3 = -1;
//Output: false
//Explanation: There is no x where 3x = (-1).



//Follow up: Could you solve it without loops/recursion?

Console.WriteLine(IsPowerOfThree(n3));

static bool IsPowerOfThree(int n)
{
	int counter = 0;

	if (n <=0)
	{
		return false;
	}

	while (n != 0 || n == 1)
	{
		if (n % 3 == 0)
		{
			counter++;
			n /= 3;
		}
		else if (n == 1)
		{
			return true;
		}
		else
		{
			return false;
		}
	}

    return true;
}