


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
				//1 162 261 467 is the largest power of 3 under 2^31 - 1
	  			//return n > 0 && 1_162_261_467 % n == 0;     ====>>>>>>>>> best solution
	
}
