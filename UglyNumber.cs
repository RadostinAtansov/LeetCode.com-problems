


//Example 1:
int n1 = 6;
//Output: true
//Explanation: 6 = 2 × 3

//Example 2:
int n2 = 1;
//Output: true
//Explanation: 1 has no prime factors, therefore all of its prime factors are limited to 2, 3, and 5.

//Example 3:
int n3 = 14;
//Output: false
//Explanation: 14 is not ugly since it includes the prime factor 7.


Console.WriteLine(IsUgly(n3));

static bool IsUgly(int n)
{
	
    if (n == 1)
    {
       return true;
    }
	else if (n < 1)
	{
		return false;
	}

    while (n > 1)
	{
		if (n % 2 == 0)
		{
			n /= 2;
		}
		else if (n % 3 == 0)
		{
            n /= 3;
        }
        else if (n % 5 == 0)
		{
            n /= 5;
        }
		else
		{
			return false;
		}
    }

    return true;
}