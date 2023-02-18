



//Example 1:
int n1 = 16;
//Output: true

//Example 2:
int n2 = 5;
//Output: false

//Example 3:
int n3 = 1;
//Output: true

Console.WriteLine(IsPowerOfFour(n3));

static bool IsPowerOfFour(int n)
{

    int counter = 0;

    if (n <= 0)
    {
        return false;
    }

    while (n != 0)
    {
        if (n % 4 == 0)
        {
            counter++;
            n /= 4;
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

    //2_147_483_648 is the largest power of 4 under 2^31 - 1
    //return n > 0 && 2_147_483_648 % n == 0;
}