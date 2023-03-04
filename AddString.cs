

//Given two non-negative integers, num1 and num2 represented as string, return the sum of num1 and num2 as a string.

//You must solve the problem without using any built-in library for handling large integers(such as BigInteger).You must also not convert the inputs to integers directly.



//Example 1:
using System.Numerics;
using System.Text;

string num1 = "11", num2 = "123";
//Output: "134"

//Example 2:
string num21 = "456", num22 = "77";
//Output: "533"

//Example 3:
string num31 = "0", num32 = "0";
//Output: "0"

string num33 = "99", num34 = "12";

Console.WriteLine(AddStrings("11", "123"));

//string num1 = "15245142151235123512352362362352351236";
//string num2 = "1522135123612646436143613461344";

static string AddStrings(string num1, string num2)
{

    int n1 = num1.Length;
    int n2 = num2.Length;

    int n = (n1 > n2) ? n1 : n2;

    if (n1 > n2)
        num2 = num2.PadLeft(n1, '0');
    else
        num1 = num1.PadLeft(n2, '0');

    char[] c = CalculateNumbers(num1, num2, n).ToString().ToCharArray();

    Array.Reverse(c);

    return String.Join("", c);
}

static int ConvertStringToInt(string num1)
{
    int response = 0;
    foreach (char c in num1)
    {
        response *= 10;
        response = response + c - '0'; //or -48 same from ascii table
    }

    return response;
}

static string CalculateNumbers(string num1, string num2, int n)
{

    int carry = 0;
    StringBuilder sum = new StringBuilder();

    for (int i = n - 1; i >= 0; i--)
    {
        char charFromTerm1 = num1[i];
        char charFromTerm2 = num2[i];
        int convertCharTointTerm1 = charFromTerm1 - 48;
        int convertCharTointTerm2 = charFromTerm2 - 48;

        int value = (carry + convertCharTointTerm1 + convertCharTointTerm2) % 10;

        sum.Append(value);

        carry = (carry + convertCharTointTerm1 + convertCharTointTerm2) / 10;
    }
    if (carry != 0)
    {
        sum.Append(carry);
    }

    return sum.ToString();
}