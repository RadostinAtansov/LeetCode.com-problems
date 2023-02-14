



//Example 1:
int n1 = 1;
//Output: true
//Explanation: 20 = 1

//Example 2:
int n2 = 16;
//Output: true
//Explanation: 24 = 16

//Example 3:
int n3 = 3;
//Output: false

Console.WriteLine(IsPowerOfTwo(n2));

static bool IsPowerOfTwo(int n)
{

    if (n <= 0)
        return false;
    var val = n & (n - 1);
    return val == 0 ? true : false;

    //var result = Math.Pow(n, 2);
    //int counter = -1;
    //if (n == 0)
    //{
    //	return false;
    //}
    //while (n != 0)
    //{
    //	if(n % 2 == 0 || n == 1)
    //	{
    //		n = n / 2;
    //		counter++;
    //       }
    //	else
    //	{
    //		return false;
    //	}

    //}

    //   return true;
}