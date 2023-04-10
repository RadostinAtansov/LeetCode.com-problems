

//Given two integers left and right, return the count of numbers in the inclusive range [left, right] having a prime number of set bits in their binary representation.

//Recall that the number of set bits an integer has is the number of 1's present when written in binary.

//For example, 21 written in binary is 10101, which has 3 set bits.


//Example 1:

int left1 = 6, right1 = 10;
//Output: 4
//Explanation:
//6-> 110(2 set bits, 2 is prime)
//7-> 111(3 set bits, 3 is prime)
//8-> 1000(1 set bit, 1 is not prime)
//9-> 1001(2 set bits, 2 is prime)
//10-> 1010(2 set bits, 2 is prime)
//4 numbers have a prime number of set bits.
//Example 2:

int left2 = 10, right2 = 15;
//Output: 5
//Explanation:
//10-> 1010(2 set bits, 2 is prime)
//11-> 1011(3 set bits, 3 is prime)
//12-> 1100(2 set bits, 2 is prime)
//13-> 1101(3 set bits, 3 is prime)
//14-> 1110(3 set bits, 3 is prime)
//15-> 1111(4 set bits, 4 is not prime)
//5 numbers have a prime number of set bits.

Console.WriteLine(CountPrimeSetBits(left2, right2));

static int CountPrimeSetBits(int left, int right)
{
	int result = 0;
	List<int> primeNumbers = new List<int>();

	for (int i = left; i <= right; i++)
	{
		string numberInBinary = Convert.ToString(i, 2);

		for (int l = 0; l < numberInBinary.Length; l++)
		{
			int number = numberInBinary[l] - '0';
			result += number;
		}
		
		if (IsPrime(result) == true)
		{
			primeNumbers.Add(result);
		}

		result = 0;

    }


    return primeNumbers.Count;
}

static bool IsPrime(int number)
{
	if (number <= 1) return false;
	if (number == 2) return true;
    if (number % 2 == 0) return false;

	var boundary = (int)Math.Floor(Math.Sqrt(number));

	for (int i = 3; i <= boundary; i+= 2)
		if (number % i == 0)
			return false;
	
    return true;
}