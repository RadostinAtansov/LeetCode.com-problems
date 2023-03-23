




using System.Collections.Generic;
using System.Diagnostics.Metrics;

//You are given a string s representing an attendance record for a student where each character signifies whether the student was absent, late, or present on that day. The record only contains the following three characters:

//'A': Absent.
//'L': Late.
//'P': Present.
//The student is eligible for an attendance award if they meet both of the following criteria:

//The student was absent ('A') for strictly fewer than 2 days total.
//The student was never late('L') for 3 or more consecutive days.
//Return true if the student is eligible for an attendance award, or false otherwise.



//Example 1:
string s1 = "PPALLP";
//Output: true
//Explanation: The student has fewer than 2 absences and was never late 3 or more consecutive days.

//Example 2:
string s2 = "PPALLL";
//Output: false
//Explanation: The student was late 3 consecutive days in the last 3 days, so is not eligible for the award.


Console.WriteLine(CheckRecord("PPALLP"));


static bool CheckRecord(string s)
{

    int counterAbsent = 0;
    int counterLate = 0;
    int late3 = 0;

    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == 'L')
        {
            counterLate++;
            if (counterLate == 3)
            {
                late3 = counterLate;
            }
        }
        else if (s[i] == 'A')
        {
            counterAbsent++;
            counterLate = 0;
        }
        else if (s[i] == 'P')
        {
            counterLate = 0;
        }
    }

    if (counterAbsent < 2 && late3 != 3)
    {
        return true;
    }
    else
    {
        return false;
    }

    return false;
}