

int x1 = 4;
int x2 = 8;
int x3 = 9;
int x4 = 45;
int x5 = 2147395599;

Console.WriteLine(MySqrt(2147395600));

static int MySqrt(int x)
{
    long result = 0;

    for (long i = 46340; i <= x; i++)
    {
        if (i * i <= x)
        {
            result = i;
        }
        else
        {
            break;
        }
    }

    return (int)result;
}