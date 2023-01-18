
public class Resume
{
    string _name;
    public List<Job> _jobs = new List<Job>();

    public Resume(string name)
    {
        this._name = name;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");

        foreach (Job _job in _jobs)
        {
            _job.Display();
        }
    }
}