

using System.Text;

string s1 = "egg", t1 = "add";
//Output: true
//Example 2:

string s2 = "foo", t2 = "bar";
//Output: false
//Example 3:

string s3 = "paper", t3 = "title";
//Output: true

Console.WriteLine(IsIsomorphic(s3, t3));

static bool IsIsomorphic(string s, string t)
{
	Dictionary<char, int> indexCharS = new Dictionary<char, int>();
	Dictionary<char, int> indexCharT = new Dictionary<char, int>();

	int countDuplicateCharS = 0;
	int countDuplicateCharT = 0;

	int[] positionOfCharS = new int[s.Length];
	int[] positionOfCharT = new int[t.Length];

	for (int i = 0; i < s.Length; i++)
	{
		char cS = s[i];
		char cT = t[i];

		//int index = s.IndexOf(c);

		if (cS < 0 && cS > 127 || cT < 0 && cT > 127)
		{
			return false;
		}
		if (!indexCharS.ContainsKey(cS))
		{
			indexCharS.Add(cS, 1);
		}
		else
		{
			indexCharS[cS]++;
		}
		if (!indexCharT.ContainsKey(cT))
		{
			indexCharT.Add(cT, 1);
		}
		else
		{
			indexCharT[cT]++;
		}
	}

	char charsS = indexCharS.Aggregate((x, y) => x.Value > y.Value ? x: y).Key;
	char charsT = indexCharT.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;

    int charsSn = indexCharS.Aggregate((x, y) => x.Value > y.Value ? x : y).Value;
    int charsTn = indexCharT.Aggregate((x, y) => x.Value > y.Value ? x : y).Value;

	if (charsSn != charsTn)
	{
		return false;
	}
    
	StringBuilder sbS = new StringBuilder(s);
	StringBuilder sbT = new StringBuilder(t);

    for (int i = 0; i < charsSn; i++)
	{
		int indexOfS = sbS.ToString().IndexOf(charsS);
		int indexOfT = sbT.ToString().IndexOf(charsT);

		sbS[indexOfS] = '#';
		sbT[indexOfT] = '#';

        if (indexOfS != indexOfT)
		{
			return false;
		}


		//positionOfCharS[i] = indexOfS;
		//positionOfCharT[i] = indexOfT;
	}

	return true;
}