



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

}
