//Given a positive integer n, find and return the longest distance between any two adjacent 1's in the binary representation of n. If there are no two adjacent 1's, return 0.

//Two 1's are adjacent if there are only 0's separating them (possibly no 0's). The distance between two 1's is the absolute difference between their bit positions. For example, the two 1's in "1001" have a distance of 3.



//Example 1:

int n1 = 22;
//Output: 2
//Explanation: 22 in binary is "10110".
//The first adjacent pair of 1's is "10110" with a distance of 2.
//The second adjacent pair of 1's is "10110" with a distance of 1.
//The answer is the largest of these two distances, which is 2.
//Note that "10110" is not a valid pair since there is a 1 separating the two 1's underlined.
//Example 2:

int n2 = 8;
//Output: 0
//Explanation: 8 in binary is "1000".
//There are not any adjacent pairs of 1's in the binary representation of 8, so we return 0.
//Example 3:

int n3 = 5;
//Output: 2
//Explanation: 5 in binary is "101".

Console.WriteLine(BinaryGap(5049));

static int BinaryGap(int n)
{

    string binary = Convert.ToString(n, 2);
    char[] filteredCollection = binary.Where(i => int.Parse(i.ToString()) != 0).ToArray();
    int startCount = 1;
    int tempStartCount = 0;
    int countOnes = 0;

    if (filteredCollection.Length < 2)
    {
        return 0;
    }

    for (int i = 0; i < binary.Length; i++)
    {
        int binaryConvert = int.Parse(binary[i].ToString());

        if (binaryConvert == 1)
        {
            countOnes++;
            if (startCount >= tempStartCount)
            {
                tempStartCount = startCount;
                startCount = 1;
                countOnes = 1;
            }
            if (countOnes > 1)
            {
                countOnes = 1;
                startCount = 1;
            }
        }
        else if (binaryConvert == 0 && countOnes == 1)
        {
            startCount++;
            if(i == binary.Length - 1)
            {
                startCount = 0;
            }
        }
    }

    return tempStartCount >= startCount ? tempStartCount : 1;
}