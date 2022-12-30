
int x = 123321;


var result = IsPalindrome(x);

    Console.WriteLine(32321%10);
Console.WriteLine(result);

static bool IsPalindrome(int x)
{

    if (x < 0)
    {
        return false;
    }

    int original = x;
    int reversed = 0;

    while (x > 0)                                     // ==> faster
    {
        int digit = x % 10;
        reversed = reversed * 10 + digit;
        x /= 10;
    }

    return original == reversed;

    //string num = x.ToString();

    //int start = 0;
    //int end = num.Length - 1;

    //while (start <= end)
    //{
    //    if (num[start] != num[end])                 ==> slower
    //    {
    //        return false;
    //    }
    //    start++;
    //    end--;
    //}

    //return true;
}