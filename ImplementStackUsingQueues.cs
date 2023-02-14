

MyStack obj = new MyStack();

obj.Push(1);


Console.WriteLine(obj.Top());
Console.WriteLine(obj.Pop());
Console.WriteLine(obj.Empty());

public class MyStack
{

    private Queue<int> queue1 = new Queue<int>();

    public MyStack()
    {
        this.queue1 = new Queue<int>();
    }

    public void Push(int x)
    {
        this.queue1.Enqueue(x);
    }

    public int Pop()
    {
        if (this.queue1.Count == 1)
        {
            return this.queue1.Dequeue();
        }

        var first = this.queue1.Peek();
        var current = 0;

        while (true)
        {
            current = queue1.Dequeue();
            if (queue1.Peek() == first)
            {
                break;
            }
            this.queue1.Enqueue(current);
        }

        return current;
    }

    public int Top()
    {
        return this.queue1.Last();
    }

    public bool Empty()
    {

        if (this.queue1.Count == 0)
        {
            return false;
        }
        return true;

    }
}
