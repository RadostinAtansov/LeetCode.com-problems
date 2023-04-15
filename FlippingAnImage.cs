﻿


//Given an n x n binary matrix image, flip the image horizontally, then invert it, and return the resulting image.

//To flip an image horizontally means that each row of the image is reversed.

//For example, flipping[1, 1, 0] horizontally results in [0,1,1].
//To invert an image means that each 0 is replaced by 1, and each 1 is replaced by 0.

//For example, inverting[0, 1, 1] results in [1,0,0].


//Example 1:

int[][] image1 = { new[] { 1, 1, 0 }, new[] { 1, 0, 1 }, new[] { 0, 0, 0 } };
//Output: [[1,0,0],[0,1,0],[1,1,1]]
//Explanation: First reverse each row: [[0,1,1],[1,0,1],[0,0,0]].
//Then, invert the image: [[1,0,0],[0,1,0],[1,1,1]]
//Example 2:

int[][] image2 = { new[] { 1, 1, 0 }, new[] { 1, 0, 1 }, new[] { 0, 0, 0 } };

//Input: image = [[1, 1, 0, 0],[1,0,0,1],[0,1,1,1],[1,0,1,0]]
//Output: [[1,1,0,0],[0,1,1,0],[0,0,0,1],[1,0,1,0]]
//Explanation: First reverse each row: [[0,0,1,1],[1,0,0,1],[1,1,1,0],[0,1,0,1]].
//Then invert the image: [[1,1,0,0],[0,1,1,0],[0,0,0,1],[1,0,1,0]]

FlipAndInvertImage(image1);

static int[][] FlipAndInvertImage(int[][] image)
{
	for (int i = 0; i < image.Length; i++)
	{
		int[] subBits = image[i];
		Array.Reverse(subBits);

		for (int r = 0; r < subBits.Length; r++)
		{
			int bit = subBits[r];
			if (bit == 1)
                subBits[r] = 0;
			else
                subBits[r] = 1;
		}
	}

    return image;
}