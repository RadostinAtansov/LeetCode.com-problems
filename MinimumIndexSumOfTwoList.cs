
//Given two arrays of strings list1 and list2, find the common strings with the least index sum.

//A common string is a string that appeared in both list1 and list2.

//A common string with the least index sum is a common string such that if it appeared at list1[i] and list2[j] then i + j should be the minimum value among all the other common strings.

//Return all the common strings with the least index sum. Return the answer in any order.



//Example 1:
string[] list1 = { "Shogun", "Tapioca Express", "Burger King", "KFC" };
string[] list2 = { "Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun" };
//Output: ["Shogun"]
//Explanation: The only common string is "Shogun".

//Example 2:
string[] list3 = {"Shogun", "Tapioca Express", "Burger King", "KFC"};
string[] list4 = {"KFC", "Shogun", "Burger King"};
//Output: ["Shogun"]
//Explanation: The common string with the least index sum is "Shogun" with index sum = (0 + 1) = 1.

//Example 3:
string[] list5 = { "happy", "sad", "good" };
string[] list6 = {"sad", "happy", "good"};
//Output: ["sad","happy"]
//Explanation: There are three common strings:
//"happy" with index sum = (0 + 1) = 1.
//"sad" with index sum = (1 + 0) = 1.
//"good" with index sum = (2 + 2) = 4.
//The strings with the least index sum are "sad" and "happy".

Console.WriteLine(string.Join(",", FindRestaurant(list3, list4)));

static string[] FindRestaurant(string[] list1, string[] list2)
{

	//List<string> result = new List<string>();
	Dictionary<string, int> strInt = new Dictionary<string, int>();
	List<string> list = new List<string>();

	for (int i = 0; i < list1.Length; i++)
	{
		if (list2.Contains(list1[i]))
		{
			int indexOf = Array.IndexOf(list2, list1[i]);
			int result = indexOf + i;

			strInt.Add(list1[i], result);
		}
	}

	strInt = strInt.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
	var fi = strInt.First().Value;
	var newCol = strInt.Where(a => a.Value == fi).ToArray();

	foreach (var item in newCol)
	{
		list.Add(item.Key);
	}

    return list.ToArray();
}