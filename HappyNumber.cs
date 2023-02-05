


using System.Diagnostics;

int n1 = 19;
//Output: true

//Explanation:
//12 + 92 = 82
//82 + 22 = 68
//62 + 82 = 100


int n2 = 2;
//Output: false

Console.WriteLine(IsHappy(n2));

static bool IsHappy(int n)
{

	int[] numbers = n.ToString().Select(q => int.Parse(q.ToString())).ToArray();
	List<int> list = new List<int>();

	int result = 0;

	while (true)
	{
		for (int i = 0; i < numbers.Length; i++)
		{
			int number = numbers[i];

			result += (int)Math.Pow(number, 2);


        }


		if (result == 1)
		{
			return true;
		}
		
		if (list.Contains(result))
		{
			return false;
		}
		list.Add(result);

        numbers = result.ToString().Select(q => int.Parse(q.ToString())).ToArray();
        result = 0;
	}

    return false;
}