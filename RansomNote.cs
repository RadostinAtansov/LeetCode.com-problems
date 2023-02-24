

//Example 1:
string ransomNote1 = "a", magazine1 = "b";
//Output: false

//Example 2:
string ransomNote2 = "aa", magazine2 = "ab";
//Output: false

//Example 3:
string ransomNote3 = "aa", magazine3 = "aab";
//Output: true


Console.WriteLine(CanConstruct(ransomNote1, magazine1));

static bool CanConstruct(string ransomNote, string magazine)
{
	List<char> listCharsMagazine = new List<char>(magazine);
	List<char> ransomNoteRansomNote = new List<char>(ransomNote);

    for (int i = 0; i < ransomNoteRansomNote.Count; i++)
	{
		char c = ransomNoteRansomNote[i];

		if (listCharsMagazine.Contains(c))
		{
			listCharsMagazine.Remove(c);     //==========> work with string are slow
		}
		else
		{
			return false;
		}
	}

    return true;
}