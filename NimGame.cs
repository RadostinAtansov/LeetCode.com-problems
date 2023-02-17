


//Example 1:

int n1 = 4;
//Output: false
//Explanation: These are the possible outcomes:
//1.You remove 1 stone.Your friend removes 3 stones, including the last stone. Your friend wins.
//2. You remove 2 stones. Your friend removes 2 stones, including the last stone. Your friend wins.
//3. You remove 3 stones. Your friend removes the last stone. Your friend wins.
//In all outcomes, your friend wins.

//Example 2:
int n2 = 1;
//Output: true

//Example 3:
int n3 = 2;
//Output: true

Console.WriteLine(CanWinNim(n1));

static bool CanWinNim(int n)
{
    return n % 4 != 0;
}