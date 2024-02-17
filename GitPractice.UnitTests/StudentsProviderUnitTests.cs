using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GitPractice.UnitTests;

[TestClass]
public class StudentsProviderUnitTests
{
    [TestMethod]
    public void StudentsGroupNotEmpty()
    {
        var studentsProvider = new StudentsProvider();

        Assert.IsTrue(studentsProvider.Students.All(x => x.Value.Count > 0));
    }

    [TestMethod]
    public void StudentsGroupsAllDifferentNumbers()
    {
        var studentsProvider = new StudentsProvider();
        var groupNumbers = studentsProvider.Students.Select(x => x.Key.Value).ToArray();
        var groupsDistinct = groupNumbers.Distinct().ToArray();

        Assert.IsFalse(groupNumbers.Except(groupsDistinct).Any());
    }

    [TestMethod]
    public void StudentsGroupNotContainsDefaultStudentAdditionalToRealStudents()
    {
        var defaultStudent = new Student("FirstName", "LastName");
        var studentsProvider = new StudentsProvider();

        Assert.IsTrue(studentsProvider.Students.All(x => x.Value.Count == 1 || !x.Value.Contains(defaultStudent)));
    }

    [TestMethod]
    public void AllStudentsUniq()
    {
        var defaultStudent = new Student("FirstName", "LastName");
        var studentsProvider = new StudentsProvider();
        var studentsRegistry = new StudentsRegistry(studentsProvider.Students);

        Assert.AreEqual(studentsRegistry.GetAll().Count, studentsRegistry.GetAll().Where(s => s != defaultStudent).Count());
    }

    [TestMethod]
    public void NoDuplicatesWithFirstNameSameAsLastName()
    {
        var studentsProvider = new StudentsProvider();
        var studentsRegistry = new StudentsRegistry(studentsProvider.Students);
        var allStudents = studentsRegistry.GetAll();

        foreach (var student in allStudents)
        {
            Assert.IsFalse(allStudents.Any(x => x.LastName == student.FirstName && x.FirstName == student.LastName));
        }
    }
}