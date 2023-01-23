


IList<IList<int>> result = Generate(1);


for (int i = 0; i < result.Count; i++)
{
	if (result.Count == 1)
	{
		Console.WriteLine("[[1]]");
	}
	else if (i == 0)
	{
		Console.Write($"[[{String.Join(",", result[i])}],");
	}
	else if (result.Count == i + 1)
	{
        Console.Write($"[{String.Join(",", result[i])}]]");
    }
    else
	{
        Console.Write($"[{String.Join(",", result[i])}],");
    }
}
	
	

static IList<IList<int>> Generate(int numRows)
{
	
	IList<int> insideList = new List<int>();
	IList<int> helperInsideList = new List<int>();
    List<IList<int>> pascalTriangleList = new List<IList<int>>();
	int counter = 1;
    if (numRows == 1)
    {
        insideList.Add(1);
        pascalTriangleList.Add(insideList);

		return pascalTriangleList;
    }

	insideList.Add(1);

    helperInsideList.Add(1);
    helperInsideList.Add(1);



	pascalTriangleList.Add(insideList);
    insideList = new List<int>();

    insideList.Add(1);
    insideList.Add(1);


    pascalTriangleList.Add(insideList);

    for (int i = 0; i < numRows - 2; i++)
	{
		for (int j = 0; j < insideList.Count - 1; j++)
		{
			int numb = insideList[j] + insideList[j + 1];

			helperInsideList[counter] = numb;
			counter++;
		}
		counter	= 1;
        helperInsideList.Add(1);
		insideList = new List<int>();

		for (int l = 0; l < helperInsideList.Count; l++)
		{
			insideList.Add(helperInsideList[l]);
		}

        pascalTriangleList.Add(insideList);
    }


    return pascalTriangleList;
}