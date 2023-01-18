using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Trainee Developer";
        job1._company = "Fastcash";
        job1._startYear = 2019;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "IT Senior Analyst";
        job2._company = "F1RST Technology";
        job2._startYear = 2020;
        job2._endYear = 2023;

        Resume resume = new Resume("Adler Orteney");
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
}