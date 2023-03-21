
//string expression convert to int calculate convert to string return string result(words)


string str = "foursixminustwotwoplusonezero";


Console.WriteLine(StringChallenge(str));



static string StringChallenge(string str)
{

    string result = string.Empty;



    Dictionary<string, int> wordToNumber = new Dictionary<string, int>()
    {
        {"zero", 0 },
        {"one", 1 },
        {"two", 2 },
        {"three", 3 },
        {"four", 4 },
        {"five", 5 },
        {"six", 6 },
        {"seven", 7 },
        {"eight", 8 },
        {"nine", 9 },
    };



    while (str.Length != 0)
    {
        string subStr3 = string.Empty;
        string subStr4 = string.Empty;
        string subStr5 = string.Empty;
        int sub3 = 0;
        int sub4 = 0;
        int sub5 = 0;


        if (str.Length >= 3)
        {
             subStr3 = str.Substring(0, 3);
             sub3 = wordToNumber.FirstOrDefault(a => a.Key == subStr3).Value;

        }
        if (str.Length >= 4)
        {
             subStr4 = str.Substring(0, 4);
             sub4 = wordToNumber.FirstOrDefault(a => a.Key == subStr4).Value;

        }
        if (str.Length >= 5)
        {
             subStr5 = str.Substring(0, 5);
             sub5 = wordToNumber.FirstOrDefault(a => a.Key == subStr5).Value;

        }

        if (subStr4 == "plus")
        {
            result += " + ";
            str = str.Remove(0, 4);
            continue;
        }
        else if (subStr5 == "minus")
        {
            result += " - ";
            str = str.Remove(0, 5);
            continue;
        }

        if (sub3 == 0 && sub4 ==  0 && sub5 == 0)
        {
            result += sub3;
            str = str.Remove(0, 4);
        }
        else if (sub3 > 0)
        {
            result += sub3;
            sub3 = 0;
            str = str.Remove(0,3);
        }
        else if (sub4 > 0)
        {
            result += sub4;
            sub4 = 0;
            str = str.Remove(0, 4);

        }
        else if (sub5 > 0)
        {
            result += sub5;
            sub5 = 0;
            str = str.Remove(0, 5);

        }

    }

    string[] strAssessment = result.Split(' ');
    int sum = int.Parse(strAssessment[0]);
    int number = 0;

    for (int i = 2; i < strAssessment.Length; i+=2)
    {

        string strSigh = strAssessment[i - 1];
        string strA = strAssessment[i];
        string minus = "-";
        string plus = "+";

        if (strA != minus || plus != "+")
        {
            number = int.Parse(strA);
            if (strSigh == minus)
            {
                sum -= number;
            }
            else
            {
                sum += number;
            }
        }
    }

    result = string.Empty;
    Stack<string> stackNumbers = new Stack<string>();

    while (sum != 0)
    {
        int reminder = sum % 10;
        sum /= 10;

        string wordDigit = wordToNumber.FirstOrDefault(n => n.Value == reminder).Key;

        stackNumbers.Push(wordDigit);
    }


    while (stackNumbers.Count() != 0)
    {
        result += stackNumbers.Pop();
    }


    return result;

}

