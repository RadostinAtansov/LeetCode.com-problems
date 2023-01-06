
int[] costs1 = { 1, 3, 2, 4, 1 };
int coins1 = 7;
//Output: 4

int[] costs2 = { 10, 6, 8, 7, 7, 8 };
int coins2 = 5;
//Output: 0

int[] costs3 = { 1, 6, 3, 1, 2, 5 };
int coins3 = 20;
//Output: 6

Console.WriteLine(MaxIceCream(costs3, coins3));


static int MaxIceCream(int[] costs, int coins)
{

	int icecreams = 0;
	int sumIcecreams = 0;
	Array.Sort(costs);

	for (int i = 0; i < costs.Length; i++)
	{
		int minIceCost = costs[i];
		sumIcecreams += minIceCost;
		if (sumIcecreams <= coins)
		{
			icecreams++;
		}
		else
		{
			sumIcecreams -= minIceCost;
			break;
		}
	}

	return icecreams;
}