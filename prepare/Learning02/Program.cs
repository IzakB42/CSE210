using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Weed Wacker";
        job1._company = "Pest co.";
        job1._startYear = 2000;
        job1._endYear = 2005;

        Job job2 = new Job();
        job2._jobTitle = "Cheese Taster Extraordinare";
        job2._company = "Underground France United";
        job2._startYear = 2006;
        job2._endYear = 2015;

        Resume myResume = new Resume();
        myResume._name = "Melt Y. Brains";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}