//mutable constructor - state is changed .

// immutable constructor- state is not changed once given
class person
{
    public string firstname { get; set; }
    public string lastname { get; set; }
    public int age { get; set; }

    private double _salary;

    public void SetSalary()
    {
        _salary = 10000;
    }
    public double GetSalary()
    {
        return _salary;
    }
    public string GetFullName()
    {
        return firstname + " " + lastname;
    }
    public string GetFullName(string middlename)
    {
        return firstname + " " + middlename + " " + lastname;
    }
}
