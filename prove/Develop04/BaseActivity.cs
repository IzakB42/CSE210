using System.Buffers.Text;

class BaseActivity
{
    public BaseActivity()
    {
        
    }
    public void RunCountDownMessage(string message, int seconds)
    {
        
        Console.CursorVisible= false;
        for(int i=seconds; i>=1; i--)
        {
            Console.Clear();
            Console.WriteLine($"{message} : {i}");
            Thread.Sleep(1000);
            // Tells program to sleep for 1000 milliseconds, ie 1 second.
        }
        Console.CursorVisible= true;
    }
    public void DisplaySpinnerMessage(string message, int seconds)
    {
        Console.CursorVisible=false;
        Console.Clear();
        Console.Write($"{message} ");
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        // for(int i=0; i < seconds; i++)
        while(DateTime.Now < endTime)
        {
            Console.Write("+");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b");
            
            // \b moves the cursor back one space, overwrites the last character.
        }
        Console.CursorVisible=true;
    }
}