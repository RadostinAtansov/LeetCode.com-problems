



//A web developer needs to know how to design a web page's size. So, given a specific rectangular web page’s area, your job by now is to design a rectangular web page, whose length L and width W satisfy the following requirements:

//The area of the rectangular web page you designed must equal to the given target area.
//The width W should not be larger than the length L, which means L >= W.
//The difference between length L and width W should be as small as possible.
//Return an array [L, W] where L and W are the length and width of the web page you designed in sequence.



//Example 1:
int area1 = 4;
//Output: [2,2]
//Explanation: The target area is 4, and all the possible ways to construct it are [1,4], [2,2], [4,1]. 
//But according to requirement 2, [1, 4] is illegal; according to requirement 3,  [4, 1] is not optimal compared to [2,2]. So the length L is 2, and the width W is 2.

//Example 2:
int area2 = 37;
//Output: [37,1]
//Example 3:

int area3 = 122122;
//Output: [427,286]

Console.WriteLine(String.Join(',', ConstructRectangle(1)));

static int[] ConstructRectangle(int area)
{
    int[] arrResult = new int[2];

    if (area == 1)
	{
        arrResult[0] = 1;
        arrResult[1] = 1;
    }
    else
    {
        int tempResult = 0;
        int tempI = 0;

        for (int i = 1; i < area; i++)
        {
            int result = area / i;
            int resultReminder = area % i;

            if (result >= i && resultReminder == 0 && result * i == area)
            {
                tempResult = result;
                tempI = i;
            }

        }

        arrResult[0] = tempResult;
        arrResult[1] = tempI;
    }

    return arrResult;
}