using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer"

        Job job2 = new Job();
        job2._jobTitle = "Software Developer"

        job1.Display()
        job2.Display()
    }
}