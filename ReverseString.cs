


//Example 1:

char[] s1 = { 'h', 'e', 'l', 'l', 'o' };
//Output: ["o","l","l","e","h"]

//Example 2:

char[] s2 = { 'H', 'a', 'n', 'n', 'a', 'h' };
//Output: ["h","a","n","n","a","H"]

ReverseString(s1);

static void ReverseString(char[] s)
{
   Array.Reverse(s);
}