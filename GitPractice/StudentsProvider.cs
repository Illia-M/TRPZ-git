using System.Collections.Immutable;

public class StudentsProvider
{
    private readonly ImmutableDictionary<GroupNumber, ImmutableList<Student>> _students;

    public StudentsProvider()
    {
        _students = new Dictionary<GroupNumber, ImmutableList<Student>>()
            {
                { new GroupNumber("IC-31"), new[]
                    {
                    new Student("Oleksandr", "Sychov"),
                    new Student("Mikita", "Kalachuk"),
                    new Student("Oleh", "Lobko"),
                    new Student("Illia", "Shmyhelskyi"),
                    new Student("Artem", "Rusachenko"),
                    new Student("Korotaiev", "Mykhailo"),
                    new Student("Driuk", "Vladyslav"),
                    new Student("Sofia", "Mykhailova"),
                    new Student("Nikita","Uzhakov"),
                    new Student("Yarslov","Shafinsky"),
                    new Student("Anastasia","Danskaya"),
                    new Student("Roman","Danuliyk"),
                    new Student("Voloshyn","Artem"),
                    new Student("Koval", "Bohdan")
                    }.ToImmutableList()
                },
                { new GroupNumber("IC-32"), new[]
                    {
                    new Student("Dmytro", "Shlikhanov"),
                    new Student("Olexandr", "Zhovmir"),
                    new Student("Yuriy", "Cherepnya"),
                    new Student("Oleksandr", "Rudenko"),
                    new Student("Maksym", "Zarytskyi"),
                    new Student("Ihor", "Panchenko")
                    }.ToImmutableList()
                },
                { new GroupNumber("IC-33"), new[]
                    {

                    new Student("FirstName", "LastName"),
                    new Student("Lipovok", "Kyrylo"),
                    new Student("Eduard", "Mikhrin")

                    }.ToImmutableList()
                },
                { new GroupNumber("IC-34"), new[]
                    {
                    new Student("Artem", "Russu"),
                    }.ToImmutableList()
                },
            }
        .ToImmutableDictionary();
    }

    public IReadOnlyDictionary<GroupNumber, ImmutableList<Student>> Students => _students;
}
