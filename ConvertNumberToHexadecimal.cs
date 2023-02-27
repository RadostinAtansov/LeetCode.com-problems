

//Example 1:
int num1 = 26;
//Output: "1a"

//Example 2:
int num2 = -1;
//Output: "ffffffff"

Console.WriteLine(ToHex(num1));

static string ToHex(int num)
{
    return num.ToString("X").ToLower();
}