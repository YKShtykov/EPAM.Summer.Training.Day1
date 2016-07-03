using StudentLibrary;
using System.Collections.Generic;
namespace StudentRepository
{
  public class Repository
  {
    private List<Student> students;

    public Repository()
    {
      students = new List<Student>();
    }
    public void Add(Student student)
    {
      students.Add(student);
    }
  }
}
