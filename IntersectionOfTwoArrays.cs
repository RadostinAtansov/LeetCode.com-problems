


//Example 1:
int[] nums11 = { 1, 2, 2, 1 }, nums21 = { 2, 2 };
//Output: [2] unique numbers

//Example 2:
int[] nums12 = { 4, 9, 5 }, nums22 = { 9, 4, 9, 8, 4 };
//Output: [9,4]
//Explanation: [4,9] is also accepted.

var result = Intersection(nums11, nums21);

Console.WriteLine(String.Join(",", result.Distinct()));

static int[] Intersection(int[] nums1, int[] nums2)
{
    List<int> result = new List<int>();
    List<int> result1 = new List<int>(nums1);
    List<int> result2 = new List<int>(nums2);
    var num1 = result1.Distinct();
    var num2 = result2.Distinct();

    for (int i = 0; i < result1.Count; i++)
    {
        int resN = result1[i];
        if (result2.Contains(resN))
        {
            result.Add(resN);
        }
    }

    var res = result.Distinct();

    return res.ToArray();
    
    
    //List<int> result = new List<int>();

    //nums1 = nums1.Distinct().ToArray();
    //nums2 = nums2.Distinct().ToArray();

    //for (int i = 0; i < nums1.Length; i++)                  =======> faster my solution
    //{
    //    int resN = nums1[i];
    //    if (nums2.Contains(resN))
    //    {
    //        result.Add(resN);
    //    }
    //}

    //return result.ToArray();
    
    
}
