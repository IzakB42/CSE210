using System;

class Program
{
    static void Main(string[] args)
    {
        BaseActivity a1 = new BaseActivity();
        // a1.RunCountDownMessage("Hello", 5);
        // a1.DisplaySpinnerMessage("Oh no!!!", 10);

        DateTime endTime = DateTime.Now.AddSeconds(15);

        while(DateTime.Now < endTime)
        {
            a1.RunCountDownMessage("Breath in . . .", 4);
            a1.RunCountDownMessage("Breath out . . .", 4);
        }

        // put up menu and loop
    }
}