﻿

//You are given an integer array cost where cost[i] is the cost of ith step on a staircase. Once you pay the cost, you can either climb one or two steps.

//You can either start from the step with index 0, or the step with index 1.

//Return the minimum cost to reach the top of the floor.



//Example 1:

int[] cost1 = { 10, 15, 20 };
//Output: 15
//Explanation: You will start at index 1.
//- Pay 15 and climb two steps to reach the top.
//The total cost is 15.
//Example 2:

int[] cost2 = { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 };
//Output: 6
//Explanation: You will start at index 0.
//- Pay 1 and climb two steps to reach index 2.
//- Pay 1 and climb two steps to reach index 4.
//- Pay 1 and climb two steps to reach index 6.
//- Pay 1 and climb one step to reach index 7.
//- Pay 1 and climb two steps to reach index 9.
//- Pay 1 and climb one step to reach the top.
//The total cost is 6.

Console.WriteLine(MinCostClimbingStairs(cost1));

static int MinCostClimbingStairs(int[] cost)
{
        
    //for (int i = cost.Length - 3; i >= 0; i--)
    //{
    //    cost[i] += Math.Min(cost[i + 1], cost[i + 2]);
    //}

    for (int i = 2; i <= cost.Length - 1; i++)
    {
        cost[i] += Math.Min(cost[i - 1], cost[i - 2]);
    }


    return Math.Min(cost[cost.Length - 1], cost[cost.Length - 2]);
}