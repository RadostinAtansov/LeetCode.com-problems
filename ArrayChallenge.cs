
int[] arr1 = { 10, 12, 4, 5, 9 };
//Output: 5
//Final Output: 5a5zwf018k62

int[] arr2 = { 14, 20, 4, 12, 5, 11 };
//Output: 8
//Final Output: 8a5zwf018k62
int[] arr3 =  { 44, 30, 24, 32, 35, 30, 40, 38, 15 };
int[] arr4 =  { 10, 9, 8, 2 };

Console.WriteLine(ArrayChallenge(arr2));

static string ArrayChallenge(int[] arr)
{

    int lowerInt = int.MaxValue;
    int saveCurrInt = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        int currentInt = arr[i];

        if (currentInt < lowerInt && i != arr.Length - 1)
        {
            saveCurrInt = currentInt;
            lowerInt = currentInt;
        }
        if (currentInt < lowerInt && i == arr.Length - 1)
        {
            return -1 + "a5zwf018k62".ToString();
        }

    }
  
    int indexOfInt = Array.IndexOf(arr, saveCurrInt);
    int lenghtOfArr = arr.Length - indexOfInt;
    int[] arrCopy = new int[lenghtOfArr];

    Array.Copy(arr, indexOfInt, arrCopy, 0, arr.Length - indexOfInt); //4, 5, 9

    int result = 0;

    for (int i = 0; i < arrCopy.Length; i++)
    {
        int lowerPrice = arrCopy[0];
        int currInt = arrCopy[i];
        int lowCurr = Math.Abs(lowerPrice - currInt);

        if (lowCurr > result)
        {
            result = lowCurr;
        }
    }

    return result + "a5zwf018k62".ToString();

}