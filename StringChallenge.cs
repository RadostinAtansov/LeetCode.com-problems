
string[] strArr1 = new string[] { "5624", "0010111111001" };
//Output: 2

string[] strArr2 = new string[] { "44", "111111" };
//Output: 3

Console.WriteLine(StringChallenge(strArr1));

static string StringChallenge(string[] strArr)
{

    int numberToBinary = int.Parse(strArr[0]);

    string binary = Convert.ToString(numberToBinary, 2);
    string binaryB = strArr[1];
    int count = 0;

    for (int i = 0; i < binaryB.Length; i++)
    {
        if (binary[i] != binaryB[i])
        {
            count++;
        }
    }

    return count.ToString();

}