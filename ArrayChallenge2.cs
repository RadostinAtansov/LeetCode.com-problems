

int[] arr1 = new int[] { 5, 10, 15 };
//Output: 8

int[] arr2 = new int[] { -2, 10, 4 };
//Output: 10

Console.WriteLine(ArrayChallenge(arr1));

static int ArrayChallenge(int[] arr)
{

    Array.Sort(arr);
    int start = arr[0];
    int end = arr[arr.Length - 1];
    int count = 0;

    List<int> list = new List<int>();

    for (int i = start; i <= end; i++)
    {
        list.Add(i);
    }

    int result = list.Count - arr.Length;

    return result;

}