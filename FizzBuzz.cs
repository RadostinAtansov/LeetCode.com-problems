
//Given an integer n, return a string array answer (1-indexed) where:

//answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
//answer[i] == "Fizz" if i is divisible by 3.
//answer[i] == "Buzz" if i is divisible by 5.
//answer[i] == i(as a string) if none of the above conditions are true.



//Example 1:

int n1 = 3;
//Output: s1 = { "1", "2", "Fizz" };
//Example 2:

int n2 = 5;
//Output: s2 = { "1", "2", "Fizz", "4", "Buzz" };
//Example 3:

int n3 = 15;
//Output: ["1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"]

Console.WriteLine(String.Join(", ", FizzBuzz(n3)));

static IList<string> FizzBuzz(int n)
{
	List<string> fizzBuzz = new List<string>();

	for (int i = 1; i <= n; i++)
	{
		int fzBz = i;
		if (i % 3 == 0 && i % 5 == 0)
			fizzBuzz.Add("FizzBuzz");
		else if (i % 3 == 0)
			fizzBuzz.Add("Fizz");
		else if (i % 5 == 0)
			fizzBuzz.Add("Buzz");
		else
			fizzBuzz.Add(i.ToString());
    }

	return fizzBuzz;
}