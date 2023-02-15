



//Example 1:
int n1 = 10;
//Output: 12
//Explanation: [1, 2, 3, 4, 5, 6, 8, 9, 10, 12] is the sequence of the first 10 ugly numbers.

//Example 2:
int n2 = 1;
//Output: 1
//Explanation: 1 has no prime factors, therefore all of its prime factors are limited to 2, 3, and 5.

Console.WriteLine(NthUglyNumber(11));

static int NthUglyNumber(int n)
{


    if (n <= 0)
        return 0;
    int a = 0, b = 0, c = 0;
    List<int> table = new List<int>();
    table.Add(1);
    while (table.Count < n)
    {
        int nextVal = Math.Min(table[a] * 2, Math.Min(table[b] * 3, table[c] * 5));
        table.Add(nextVal);
        if (table[a] * 2 == nextVal)
            a++;
        if (table[b] * 3 == nextVal)
            b++;
        if (table[c] * 5 == nextVal)
            c++;
    }
    return table.Last();

    //<================================================>||<====================================================>



    //out of memory



    //List<int> listOfPositiveUnglyNumbers = new List<int>() { 1 };
    //int counter = 2;
    //if (n == 1)
    //{
    //	return 1;
    //}

    //while (n != listOfPositiveUnglyNumbers.Count)
    //{
    //       if (counter % 2 == 0)
    //       {
    //           int result = Calculations(counter);
    //           if (result != -1)
    //           {
    //               listOfPositiveUnglyNumbers.Add(counter);
    //           }
    //       }
    //       else if (counter % 3 == 0)
    //	{

    //           int result = Calculations(counter);
    //           if (result != -1)
    //           {
    //               listOfPositiveUnglyNumbers.Add(counter);
    //           }
    //       }
    //       else if (counter % 5 == 0)
    //	{

    //           int result = Calculations(counter);
    //           if (result != -1)
    //           {
    //               listOfPositiveUnglyNumbers.Add(counter);
    //           }
    //       }
    //	counter++;
    //   }

    //   return listOfPositiveUnglyNumbers[listOfPositiveUnglyNumbers.Count - 1];
}

//static int Calculations(int n)
//{
//    while (n > 1)
//    {
//        if (n % 2 == 0)
//        {
//            n /= 2;
//        }
//        else if (n % 3 == 0)
//        {
//            n /= 3;
//        }
//        else if (n % 5 == 0)
//        {
//            n /= 5;
//        }
//        else
//        {
//            return -1;
//        }
//    }

//    return n;
//}