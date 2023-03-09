
//The complement of an integer is the integer you get when you flip all the 0's to 1's and all the 1's to 0's in its binary representation.

//For example, The integer 5 is "101" in binary and its complement is "010" which is the integer 2.




Console.WriteLine(FindComplement(1));

static int FindComplement(int num)
{
    char[] binary = Convert.ToString(num, 2).ToCharArray();

    for (int i = 0; i < binary.Length; i++)
    {
        if (binary[i] == '1')
        {
            binary[i] = '0';
        }
        else
        {
            binary[i] = '1';
        }
    }

    string str = new string(binary);
    int numberBinary = Convert.ToInt32(str, 2);

    return numberBinary;
}