using System.Numerics;

int[] digits1 = { 1, 2, 3 };
//Output: [1,2,4]
int[] digits2 = { 4, 3, 2, 1 };
//Output: [4,3,2,2]
int[] digits3 = { 9 };
//Output: [1, 0]
int[] digits4 = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
//Output: [ 9,8,7,6,5,4,3,2,1,0 ]
int[] digits5 = { 7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4, 0, 0, 6 };
//Output: [ 9,8,7,6,5,4,3,2,1,0 ]

PlusOne(digits5);

static int[] PlusOne(int[] digits)
{
    string str = string.Join("", digits);
    BigInteger digit = BigInteger.Parse(str);
    digit += 1;
    string strInt = Convert.ToString(digit);

    int[] newDigits = new int[strInt.Length];  

    for (int i = 0; i < strInt.Length; i++)
    {
        int s = int.Parse(strInt[i].ToString());
        newDigits[i] = s;
    }

    Console.WriteLine(String.Join(',', newDigits));

    return newDigits;


    //bool carry = true;
    //for (int i = digits.Length - 1; i >= 0 && carry; i--)
    //{
    //    digits[i] = (digits[i] + 1) % 10;
    //    carry = digits[i] == 0;
    //}

    //if (carry)
    //{
    //    digits = new int[digits.Length + 1];                        // less memory
    //    digits[0] = 1;

    //}
    //return digits;
}