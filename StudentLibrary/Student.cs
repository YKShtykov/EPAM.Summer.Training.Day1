namespace StudentLibrary
{
  public class Student
  {
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Id { get; set; }

    public int Age { get; set; }

    public Student(string firstName, string lastName, int age)
    {
      FirstName = firstName;
      LastName = LastName;
      Age = Age;
    }

    public override string ToString()
    {
      return string.Format("{0} {1}, {2} years;", FirstName, LastName, Age);
    }
  }
}
