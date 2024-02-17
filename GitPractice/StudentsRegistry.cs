using System.Collections.Immutable;

public class StudentsRegistry
{
    private readonly IReadOnlyDictionary<GroupNumber, ImmutableList<Student>> _students;

    public StudentsRegistry(IReadOnlyDictionary<GroupNumber, ImmutableList<Student>> students)
    {
        _students = students;
    }

    public IReadOnlyCollection<Student> GetAll()
    {
        return _students.SelectMany(x => x.Value).ToArray();
    }
}