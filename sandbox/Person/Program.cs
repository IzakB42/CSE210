class Program
{
    static void DisplayPersonInformation(Person person)
        {
            // if(person is Doctor d)
            //     Console.WriteLine(d.GetDoctorInfo());
            // else if(person is Police p)
            //     Console.WriteLine(p.GetPoliceInformation());
            // else
            //     Console.WriteLine(person.GetPersonInfo());
            Console.WriteLine($"Salary: {person.GetSalary()}");
            Console.WriteLine(person.GetPersonInfo());
        }
    static void Main()
    {
        // Person p1 = new Person("Jozzy", "Jeshim", 42, 110);

        Doctor d1 = new Doctor("Doctor", "Doctor", 799, 140, "sonic screwdriver");

        Police po1 = new Police("Danger", "Buff", 29, 200, "Nunchucks");

        List<Person> myPeople = new List<Person>();

        // myPeople.Add(p1);

        myPeople.Add(d1);

        myPeople.Add(po1);

        foreach(Person person in myPeople)
        {
            DisplayPersonInformation(person);
        }


        
    }
}