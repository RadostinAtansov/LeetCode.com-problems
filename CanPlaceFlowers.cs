//You have a long flowerbed in which some of the plots are planted, and some are not. However, flowers cannot be planted in adjacent plots.

//Given an integer array flowerbed containing 0's and 1's, where 0 means empty and 1 means not empty, and an integer n, return true if n new flowers can be planted in the flowerbed without violating the no-adjacent-flowers rule and false otherwise.



//Example 1:
int[] flowerbed1 = {1, 0, 0, 0, 1};
int n1 = 1;
//Output: true

//Example 2:
int[] flowerbed2 = {1, 0, 0, 0, 1};
int n2 = 2;
//Output: false
                                                  //1
Console.WriteLine(CanPlaceFlowers(new int[] { 1, 0, 0, 0, 1, 0, 0 }, 2));

static bool CanPlaceFlowers(int[] flowerbed, int n)
{
    int counter = 0;

    for (int i = 1; i <= flowerbed.Length; i++)
    {
        if (flowerbed[i - 1] == 1)
        {
            i++;
        }
        else if (flowerbed[i - 1] == 0 && i == flowerbed.Length)
        {
            counter++;
        }
        else if (flowerbed[i - 1] == 0 && flowerbed[i] != 1)
        {
            i++;
            counter++;
        }
    }
    
    return counter >= n ? true : false;
}