using System.Collections.Generic;

public class StudentsRegistry
{
    private IReadOnlyDictionary<GroupNumber, Student> _students;

    public StudentsRegistry(IReadOnlyDictionary<GroupNumber, Student> students)
    {
        _students = students;
    }

    public IReadOnlyCollection<Student> GetAll()
    {
        return _students.Values.ToArray();
    }
}
