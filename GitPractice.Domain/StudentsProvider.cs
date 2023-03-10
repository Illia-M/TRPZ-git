using System;
using System.Collections.Immutable;

public class StudentsProvider
{
    private ImmutableDictionary<GroupNumber, ImmutableList<Student>> _students;

    public StudentsProvider()
    {
        _students = new Dictionary<GroupNumber, ImmutableList<Student>>()
            {
                { new GroupNumber("IC-21"), new[]{
                    new Student("Artem", "Liakh"),
                    new Student("Nataliia", "Petrovych"),
                    new Student("Volodymyr", "Liepieiev"),
                    new Student("Danylo","Honcharov"),

                }.ToImmutableList() },
                { new GroupNumber("IC-22"), new[]{
                    new Student("Maxym", "Shapoval"),
                    new Student("Dania", "Holovach"),
                    new Student("Maxim", "Grinevich"),
                    new Student("Roman", "Denysiuk"),
                }.ToImmutableList() },
                { new GroupNumber("IC-23"), new[]{
                    new Student("Katya", "Myronets"),
                    new Student("Artem", "Leschenko"),
                    new Student("Pavlo", "Ovsyuk"),
                    new Student("Bogdan", "Gilevich"),
                    new Student("Kirill", "Nesterenko"),
                    new Student("Yana", "Pron"),
                    new Student("Yaroslav", "Dobrutskiy"),
                }.ToImmutableList() },
            }
        .ToImmutableDictionary();
    }
}
