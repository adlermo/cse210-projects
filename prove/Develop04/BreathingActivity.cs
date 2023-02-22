class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description) { }

    public void BreathingExercise()
    {
        while (!base.IsActivityTimedUp())
        {
            Console.WriteLine();
            Console.Write("Breath in... ");
            DisplaySeconds(5);

            Console.WriteLine();
            Console.Write("Breath out... ");
            DisplaySeconds(6);

            Console.WriteLine();
        }
    }

}
