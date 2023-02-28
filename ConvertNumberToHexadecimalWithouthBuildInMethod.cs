

//Example 1:
int num1 = 26;



//Output: "1a"

//Example 2:
int num2 = -1;
//Output: "ffffffff"

//int num = 313;
int n = -1;
int maxInt = int.MaxValue;
long maxlong = uint.MaxValue;
Console.WriteLine(maxlong);

Console.WriteLine(ToHex(-2));

static string ToHex(int num)
{
    //return num.ToString("X").ToLower();    -------------------------------------------- Down --- Solution without build in method! -------------------------------------------- 

    if (num == 0)
    {
        return 0.ToString();
    }

    Dictionary<long, string> hexaNumbers = new Dictionary<long, string>() {
                                                                           { 0, "0" },
                                                                           { 1, "1" },
                                                                           { 2, "2" },
                                                                           { 3, "3" },
                                                                           { 4, "4" },
                                                                           { 5, "5" },
                                                                           { 6, "6" },
                                                                           { 7, "7" },
                                                                           { 8, "8" },
                                                                           { 9, "9" },
                                                                           { 10, "a" },
                                                                           { 11, "b" },
                                                                           { 12, "c" },
                                                                           { 13, "d" },
                                                                           { 14, "e" },
                                                                           { 15, "f" },
                                                                        };
    long numberMax = 0;
    List<string> hexaNumber = new List<string>();
    if (num == -1)
    {
        numberMax = uint.MaxValue;
        return HexaConverter(numberMax, hexaNumbers, hexaNumber);
    }
    else if (num < -1)
    {
        //num = num + 1;
        numberMax = uint.MaxValue + num + 1;
        return HexaConverter(numberMax, hexaNumbers, hexaNumber);
    }
    else
    {
        return HexaConverter(num, hexaNumbers, hexaNumber);
    }

}

static string HexaConverter(long num, Dictionary<long, string> hexaNumbers, List<string> hexaNumber)
{
    float reminder = 0f;
    long numberInfronOfPoint = 0;
    while (true)
    {
        if (num > 15)
        {
            reminder = num % 16;
            if (hexaNumbers.ContainsKey((long)reminder))
            {
                var hexNum = hexaNumbers.FirstOrDefault(x => x.Key == reminder).Value;
                hexaNumber.Add(hexNum);
            }
            else
            {
                reminder *= 16;
            }
            num = num / 16;
        }
        if (num < 16 && num > 0)
        {
            var hexNum = hexaNumbers.FirstOrDefault(x => x.Key == num).Value;
            hexaNumber.Add(hexNum);
            break;
        }

    }

    hexaNumber.Reverse();
    return String.Join("", hexaNumber);
}