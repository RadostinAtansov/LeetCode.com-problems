
using System;

string s = "()[]{}"; //true
string s2 = "{[]}"; //true
string s3 = "([)]"; //false
string s4 = "([{}])"; //true

Console.WriteLine(IsValid(s3));

static bool IsValid(string s)
{

    Stack<char> st = new Stack<char>();
    char[] arr = new char[s.Length];
    arr = s.ToCharArray();
    if (s.Length % 2 != 0)
        return false;

    for (int i = 0; i < arr.Length; i++)
    {
        char ch = arr[i];

        if (ch == '(' || ch == '[' || ch == '{')
        {
            st.Push(ch);
            Console.WriteLine("for " + i + " pushed " + ch);

        }
        if (st.Count <= 0)
        {
            return false;
        }

        else if (ch == ')')
        {
            if (st.Peek() == '(')
            {
                //Console.WriteLine("for ) poped " + st.Peek());
                st.Pop();
            }
            else
                return false;

        }
        else if (ch == '}')
        {
            if (st.Peek() == '{')
            {
                //Console.WriteLine("for } poped " + st.Peek());
                st.Pop();

            }
            else
                return false;
        }
        else if (ch == ']')
        {
            if (st.Peek() == '[')
            {
                //Console.WriteLine("for ] poped " + st.Peek());
                st.Pop();
            }
            else
                return false;
        }
    }
    if (st.Count > 0)
        return false;
    return true;
    
}