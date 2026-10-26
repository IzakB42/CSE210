class Person
{
    private string _firstname;
    private string _lastname;
    private int _age;
    private double _weight;

    public Person(string firstName, string lastName, int age, double weight)
    {
        _firstname = firstName;
        _lastname = lastName;
        _age = age;
        _weight = weight;
    }

    public void DisplayPersonInfo()
    {
        Console.WriteLine($"{_firstname} {_lastname} is {_age} years old and weighs {_weight} lbs.");
    }
}