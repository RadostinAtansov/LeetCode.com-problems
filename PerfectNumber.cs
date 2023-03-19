

//A perfect number is a positive integer that is equal to the sum of its positive divisors, excluding the number itself. A divisor of an integer x is an integer that can divide x evenly.

//Given an integer n, return true if n is a perfect number, otherwise return false.



//Example 1:
int num1 = 28;
//Output: true
//Explanation: 28 = 1 + 2 + 4 + 7 + 14
//1, 2, 4, 7, and 14 are all divisors of 28.

//Example 2:
int num2 = 7;
//Output: false

Console.WriteLine(CheckPerfectNumber(496));

static bool CheckPerfectNumber(int num)
{
    List<int> devidedNumbers = new List<int>();

    for (int i = 1; i < num; i++)
    {
        if (num % i == 0)
        {
            devidedNumbers.Add(i);
        }
    }

    int sumDevidedNumbers = devidedNumbers.Sum();

    bool isEqual = sumDevidedNumbers == num ? true : false;

    return isEqual;
}