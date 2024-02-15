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
                    new Student("Evgen", "Tkachenko"),
                    new Student("Oleksandr", "Sychov"),
                    new Student("Mikita", "Kalachuk"),
                    new Student("Oleh", "Lobko"),
                    new Student("Illia", "Shmyhelskyi"),
                    new Student("Artem", "Rusachenko"),
                    new Student("Iryna", "Berezka"),
                    new Student("Anastasia", "Savenko"),
                    new Student("Vladyslav", "Driuk"),
                    new Student("Sofia", "Mykhailova"),
                    new Student("Nikita","Uzhakov"),
                    new Student("Violetta","Rebrova"),
                    new Student("Yaroslav","Shafinsky"),
                    new Student("Anastasia","Danskaya"),
                    new Student("Voloshyn","Artem"),
                    new Student("Anastasiya","Nepron"),
                    new Student("Roman","Danuliyk"),
                    new Student("Maksym","Harmash"),
                    new Student("Bohdan", "Koval"),
                    new Student("Andrii", "Shevchuk"),
                    new Student("Mykhailo", "Korotaiev"),
                    new Student("Artem", "Voloshyn"),
                    new Student("Dmytro", "Belousov"),
                    new Student("Dmytro","Statkevych"),
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
                    new Student("Vladyslav", "Kiselar"),
                    new Student("Katya", "Linnyk"),
                    new Student("Valeriia", "Kovaliuk")
                    }.ToImmutableList()
                },
                { new GroupNumber("IC-33"), new[]
                    {
                    new Student("Anastasiia", "Babenko"),
                    new Student("Varvara", "Kalenichenko"),
                    new Student("Lipovok", "Kyrylo"),
                    new Student("Eduard", "Mikhrin"),
                    new Student("Vladyslav", "Zhukov"),
                    new Student("Kateryna","Tarasenko"),
                    new Student("Oleg", "Domozhilkin"),
                    new Student("Maksym", "Litynskyi"),
                    new Student("Katya", "Semeniuk"),
                    new Student("Maksym", "Trofimchuk")
                    }.ToImmutableList()
                },
                { new GroupNumber("IC-34"), new[]
                    {
                    new Student("Diana", "Romaniuk"),
                    new Student("Yaroslav", "Lenchenko"),
                    new Student("Dmytro", "Sytnyk"),
                    new Student("Artem", "Russu"),
                    new Student("Alex", "Hezha"),
                    new Student("Vlad", "Pohorilets"),
                    new Student("Liudmyla", "Perekhrest"),
                    new Student("Mykyta","Pedko"),
                    new Student("Kostiantyn", "Tkachov"),
                    new Student("Mariia", "Zozulia"),
                    new Student("Daryna","Shnaider"),
                    new Student("Oleksandra", "Yashchenko"),
                    new Student("Mykhailo","Kornieiev"),
                    new Student("Yelyzaveta","Frusenko"),
                    new Student("Andrii","Drabovych"),
                    new Student("Yehor","Zaleskyi"),
                    new Student("Andrew","Shved"),

                    }.ToImmutableList()
                },
            }
        .ToImmutableDictionary();
    }

    public IReadOnlyDictionary<GroupNumber, ImmutableList<Student>> Students => _students;
}
