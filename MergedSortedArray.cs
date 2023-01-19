
int[] nums1 = { 1, 2, 3, 0, 0, 0 };
int m1 = 3; 
int[] nums2 = { 2, 5, 6 };
int n1 = 3;
//
int[] nums3 = { 1 };
int m2 = 1;
int[] nums4 = { };
int n2 = 0;
//
int[] nums5 = { 0 };
int m3 = 0;
int[] nums6 = { 1 };
int n3 = 1;

Merge(nums5, m3, nums6, n3);

static void Merge(int[] nums1, int m, int[] nums2, int n)
{
		

	for (int i = 0; i < nums2.Length; i++)
	{
		nums1[m + i] = nums2[i];
	}

	Array.Sort(nums1);

	Console.WriteLine(string.Join(" ", nums1));
}