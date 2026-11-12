abstract class Person
{
    protected string _firstname;
    protected string _lastname;
    protected int _age;
    protected double _weight;

    public Person(string firstName, string lastName, int age, double weight)
    {
        _firstname = firstName;
        _lastname = lastName;
        _age = age;
        _weight = weight;
    }

    // public void DisplayPersonInfo()
    // {
    //     Console.WriteLine($"{_firstname} {_lastname} is {_age} years old and weighs {_weight} lbs.");
    // }
    public virtual string GetPersonInfo()
    {
        return $"{_firstname} {_lastname} is {_age} years old and weighs {_weight} lbs.";
    }
    public abstract double GetSalary();
    // Each derived class has a different code for abstract methods.
    // Each one MUST have one, and since the method is abstract, the class must be as well.
    // Can't use base abstract classes, must use the derived classes with abstract method code.
}