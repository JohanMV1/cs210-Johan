using System;
class program
{
    static void Main(string[]args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1. _company = "uber";
        job1._startYear = 2023;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "supervisor";
        job2._company = "Microsoft";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Johan Villarreal";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}