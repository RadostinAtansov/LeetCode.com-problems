



//Example 1:
//Input: num = 16
//Output: true
//Explanation: We return true because 4 * 4 = 16 and 4 is an integer.



//Example 2:
//Input: num = 14
//Output: false
//Explanation: We return false because 3.742 * 3.742 = 14 and 3.742 is not an integer.

Console.WriteLine(IsPerfectSquare(9));

static bool IsPerfectSquare(int num)
{

    if (num == 1)
    {
        return true;
    }

    double root = num / 3;
    if (num > 0)
    {
                                                                        //without Math.Sqrt()
        for (int i = 0; i < 32; i++)
        {
            root = (root + num / root) / 2;
        }
        //Console.WriteLine("Square root:{0}", root);  
        if (num % root == 0)
        {
            return true;
        }
    }

    return false;
}