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
                    new Student("Anastasia", "Savenko"),
                    new Student("Korotaiev", "Mykhailo"),
                    new Student("Vladyslav", "Driuk"),
                    new Student("Sofia", "Mykhailova"),
                    new Student("Nikita","Uzhakov"),
                    new Student("Yarslov","Shafinsky"),
                    new Student("Anastasia","Danskaya"),
                    new Student("Roman","Danuliyk"),
                    new Student("Voloshyn","Artem"),
                    new Student("Maksym","Harmash"),
                    new Student("Koval", "Bohdan"),
                    new Student("Dmytro", "Statkevych"),
                    }.ToImmutableList()
                },
                { new GroupNumber("IC-32"), new[]
                    {
                    new Student("Dmytro", "Shlikhanov"),
                    new Student("Olexandr", "Zhovmir"),
                    new Student("Yuriy", "Cherepnya"),
                    new Student("Oleksandr", "Rudenko"),
                    new Student("Maksym", "Zarytskyi"),
                    new Student("Ihor", "Panchenko"),
                    new Student("Dariia", "Plieshkova"),
                    new Student("Olexandr", "Fetisov"),
                    new Student("Tina", "Topka"),
                    new Student("Artem", "Reutenko"),
                    new Student("Katya", "Linnyk"),
                    new Student("Valeriia", "Kovaliuk"),
                    }.ToImmutableList()
                },
                { new GroupNumber("IC-33"), new[]
                    {
                    new Student("Lipovok", "Kyrylo"),
                    new Student("Eduard", "Mikhrin"),
                    new Student("Vladyslav", "Zhukov")
                    }.ToImmutableList()
                },
                { new GroupNumber("IC-34"), new[]
                    {
                    new Student("Yaroslav", "Lenchenko"),
                    new Student("Artem", "Russu")
                    }.ToImmutableList()
                },
            }
        .ToImmutableDictionary();
    }

    public IReadOnlyDictionary<GroupNumber, ImmutableList<Student>> Students => _students;
}
