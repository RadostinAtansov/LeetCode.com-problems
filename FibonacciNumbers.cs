

//The Fibonacci numbers, commonly denoted F(n) form a sequence, called the Fibonacci sequence, such that each number is the sum of the two preceding ones, starting from 0 and 1. That is,

//F(0) = 0, F(1) = 1
//F(n) = F(n - 1) + F(n - 2), for n > 1.
//Given n, calculate F(n).



//Example 1:
int n = 2;
//Output: 1
//Explanation: F(2) = F(1) + F(0) = 1 + 0 = 1.

//Example 2:
int n1 = 3;
//Output: 2
//Explanation: F(3) = F(2) + F(1) = 1 + 1 = 2.

//Example 3:
int n2 = 4;
//Output: 3
//Explanation: F(4) = F(3) + F(2) = 2 + 1 = 3.



int number = 0;

var result = Fib(number);

Console.WriteLine(result);

static int Fib(int n)
{
    int firstNumber = 0;
    int secondNumber = 1;
    int resultNumber = 0;

    if (n == 1)
    {
        return 1;
    }
    else if (n == 2)
    {
        return 1;
    }

    for (int i = 0; i < n - 1; i++)
    {
        resultNumber = firstNumber + secondNumber;
        firstNumber = secondNumber;
        secondNumber = resultNumber;
    }

    return resultNumber;
}