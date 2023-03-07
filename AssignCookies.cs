


//Assume you are an awesome parent and want to give your children some cookies. But, you should give each child at most one cookie.

//Each child i has a greed factor g[i], which is the minimum size of a cookie that the child will be content with; and each cookie j has a size s[j]. If s[j] >= g[i], we can assign the cookie j to the child i, and the child i will be content. Your goal is to maximize the number of your content children and output the maximum number.



//Example 1:
int[] g1 = { 1, 2, 3 }, s1 = { 1, 1 };
//Output: 1
//Explanation: You have 3 children and 2 cookies. The greed factors of 3 children are 1, 2, 3. 
//And even though you have 2 cookies, since their size is both 1, you could only make the child whose greed factor is 1 content.
//You need to output 1.

//Example 2:
int[] g2 = { 1, 2 };
int[] s2 = { 1, 2, 3 };


int[] g3 = { 2, 4, 5 };
int[] s3 = { 3, 23, 5, 3, 54, 12, 432, 342, 123, 123, 123 };
//Output: 2
//Explanation: You have 2 children and 3 cookies. The greed factors of 2 children are 1, 2. 
//You have 3 cookies and their sizes are big enough to gratify all of the children,
//You need to output 2.

Console.WriteLine(FindContentChildren(g2, s2));

static int FindContentChildren(int[] g, int[] s)
{
    Array.Sort(g);
    Array.Sort(s);
    int child = 0;
    int cookie = 0;
    while (child < g.Length && cookie < s.Length)
    {
        if (g[child] <= s[cookie])
        {
            child++;
        }
        else
        {
            cookie++;
        }
    }
    return child;
}