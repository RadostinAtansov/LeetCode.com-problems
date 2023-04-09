//A self-dividing number is a number that is divisible by every digit it contains.

//For example, 128 is a self-dividing number because 128 % 1 == 0, 128 % 2 == 0, and 128 % 8 == 0.
//A self-dividing number is not allowed to contain the digit zero.

//Given two integers left and right, return a list of all the self-dividing numbers in the range [left, right].



//Example 1:

int left1 = 1, right1 = 22;
//Output: [1,2,3,4,5,6,7,8,9,11,12,15,22]
//Example 2:

int left2 = 47, right2 = 85;
//Output: [48,55,66,77]



Console.WriteLine(String.Join(',', SelfDividingNumbers(left1, right1)));

static IList<int> SelfDividingNumbers(int left, int right)
{
	IList<int> result = new List<int>();

    for (int i = left; i <= right; i++)
    {
        int numberToDivide = i;

        if (numberToDivide.ToString().Contains('0'))
            continue;   

        if (CheckDivisible(numberToDivide) == -1)
            continue;
        else
            result.Add(numberToDivide);
    }

    return result;
}


static int CheckDivisible(int number)
{
    int result = number;


    while (number != 0)
    {
        int reminder = number % 10;

        double reslt = result % reminder;

        if (reslt != 0)
        {
            return -1;
        }
        number /= 10;
    }
	return result;
}