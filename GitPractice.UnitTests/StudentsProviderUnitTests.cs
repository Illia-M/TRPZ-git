namespace GitPractice.UnitTests;

public class StudentsProviderUnitTests
{
    [Fact]
    public void StudentsGroupNotEmpty()
    {
        var studentsProvider = new StudentsProvider();

        Assert.True(studentsProvider.Students.All(x => x.Value.Count > 0));
    }

    [Fact]
    public void StudentsGroupsAllDifferentNumbers()
    {
        var studentsProvider = new StudentsProvider();
        var groupNumbers = studentsProvider.Students.Select(x => x.Key.Value).ToArray();
        var groupsDistinctCount = groupNumbers.Distinct().ToArray();

        Assert.Equal(groupNumbers, groupsDistinctCount);
    }

    [Fact]
    public void StudentsGroupNotContainsDefaultStudentAdditionalToRealStudents()
    {
        var defaultStudent = new Student("FirstName", "LastName");
        var studentsProvider = new StudentsProvider();

        Assert.True(studentsProvider.Students.All(x => x.Value.Count == 1 || !x.Value.Contains(defaultStudent)));
    }

    [Fact]
    public void AllStudentsUniq()
    {
        var defaultStudent = new Student("FirstName", "LastName");
        var studentsProvider = new StudentsProvider();
        var studentsRegistry = new StudentsRegistry(studentsProvider.Students);

        Assert.Distinct(studentsRegistry.GetAll().Where(s => s != defaultStudent));
    }

    [Fact]
    public void NoDuplicatesWithFirstNameSameAsLastName()
    {
        var studentsProvider = new StudentsProvider();
        var studentsRegistry = new StudentsRegistry(studentsProvider.Students);
        var allStudents = studentsRegistry.GetAll();

        foreach (var s in allStudents)
        {
            Assert.DoesNotContain(allStudents, x => x.LastName == s.FirstName && x.FirstName == s.LastName);
        }
    }
}