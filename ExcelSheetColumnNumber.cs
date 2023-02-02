
string columnTitle1 = "A";
//Output: 1

string columnTitle2 = "AB";
//Output: 28

string columnTitle3 = "ZY";
//Output: 701

string columnTitle4 = "FXSHRXW";
//Output: 2147483647

Console.WriteLine(TitleToNumber(columnTitle4));

static int TitleToNumber(string columnTitle)
{

    var storage = new Dictionary<char, int>()
        {
            { 'A', 1 },
            { 'B', 2 },
            { 'C', 3 },
            { 'D', 4 },
            { 'E', 5 },
            { 'F', 6 },
            { 'G', 7 },
            { 'H', 8 },
            { 'I', 9 },
            { 'J', 10 },
            { 'K', 11 },
            { 'L', 12 },
            { 'M', 13 },
            { 'N', 14 },
            { 'O', 15 },
            { 'P', 16 },
            { 'Q', 17 },
            { 'R', 18 },
            { 'S', 19 },
            { 'T', 20 },
            { 'U', 21 },
            { 'V', 22 },
            { 'W', 23 },
            { 'X', 24 },
            { 'Y', 25 },
            { 'Z', 26 }
        };

    if (columnTitle.Length == 1)
    {
        return storage[columnTitle.ToCharArray()[0]];
    }

    var index = 0;
    var number = 0;
    for (var i = columnTitle.Length - 1; i >= 0; i--)
    {
        number += index > 0
        ? (int)Math.Pow(26, index) * storage[columnTitle[i]]
        : storage[columnTitle[i]];
        index++;
    }

    return number;


    //Dictionary<char, int> keyCharValueNumber = new Dictionary<char, int>()
    //{
    //    {'A', 1 }, {'B', 2 },  {'C', 3 }, {'D', 4 }, {'E', 5 },
    //    {'F', 6 }, {'G', 7 }, {'H', 8 }, {'I', 9 }, {'J', 10 },
    //    {'K', 11 }, {'L', 12 }, {'M', 13 }, {'N', 14 }, {'O', 15 },
    //    {'P', 16 }, {'Q', 17 }, {'R', 18 }, {'S', 19 }, {'T', 20 },
    //    {'U', 21 }, {'V', 22 }, {'W', 23 }, {'X', 24 }, {'Y', 25 },
    //    {'Z', 26 },
    //};

    //int sum = 0;
    //int numberOfChar = 0;
    ////char nextChar = '\0';

    //if (columnTitle.Length == 1) return keyCharValueNumber[columnTitle[0]];

    //sum = keyCharValueNumber[columnTitle[0]] * 26;

    //for (int i = 1; i < columnTitle.Length - 1; i++)
    //{
    //    int val = keyCharValueNumber[columnTitle[i]] * 26;
    //    sum = sum * 26 + val;
    //}

    //return sum + keyCharValueNumber[columnTitle[columnTitle.Length - 1]];
}