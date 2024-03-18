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
                    new Student("Oleksii", "Anokhin"),
                    new Student("Evgen", "Tkachenko"),
                    new Student("Oleksandr", "Sychov"),
                    new Student("Mikita", "Kalachuk"),
                    new Student("Oleh", "Lobko"),
                    new Student("Illia", "Shmyhelskyi"),
                    new Student("Artem", "Rusachenko"),
                    new Student("Iryna", "Berezka"),
                    new Student("Anastasia", "Savenko"),
                    new Student("Vladyslav", "Driuk"),
                    new Student("Nikita","Uzhakov"),
                    new Student("Sofia", "Mykhailova"),
                    new Student("Violetta","Rebrova"),
                    new Student("Yaroslav","Shafinsky"),
                    new Student("Anastasia","Danskaya"),
                    new Student("Anastasiya","Nepron"),
                    new Student("Roman","Danuliyk"),
                    new Student("Maksym","Harmash"),
                    new Student("Bohdan", "Koval"),
                    new Student("Andrii", "Shevchuk"),
                    new Student("Mykhailo", "Korotaiev"),
                    new Student("Artem", "Voloshyn"),
                    new Student("Dmytro", "Belousov"),
                    new Student("Dmytro","Statkevych"),
                    new Student("Artem","Sychov"),
                    new Student("Anastasia","Yalovitsa"),
                    new Student("Anna","Mamchuk"),
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
                    new Student("Valeriia", "Kovaliuk"),
                    new Student("Nataliia", "Cherviakova"),
                    new Student("Maryna", "Bondar"),
                    new Student("Valeriia", "Temko"),
                    new Student("Oleksandra", "Lemaeva"),
                    new Student("Karolina", "Rudykh"),
                    new Student("Nazar", "Kyrychenko"),
                    new Student("Maria","Aralova"),
                    new Student("Mykhailo","Pylypenko"),
                    new Student("Dmytro","Reznik"),
                    new Student("Kyryl", "Kravets"),
                    new Student("Artem","Minko"),
                    }.ToImmutableList()
                },
                { new GroupNumber("IC-33"), new[]
                    {
                    new Student("Anastasiia", "Babenko"),
                    new Student("Varvara", "Kalenichenko"),
                    new Student("Kyrylo", "Lipovok"),
                    new Student("Eduard", "Mikhrin"),
                    new Student("Vladyslav", "Zhukov"),
                    new Student("Kateryna","Tarasenko"),
                    new Student("Oleg", "Domozhilkin"),
                    new Student("Maksym", "Litynskyi"),
                    new Student("Katya", "Semeniuk"),
                    new Student("Maksym", "Trofimchuk"),
                    new Student("Veronika", "Slyvka"),
                    new Student("Oleh", "Buriachok"),
                    new Student("Bohdan", "Korniienko"),
                    new Student("Maksym", "Kurenkov"),
                    new Student("Anton", "Lykholit"),
                    new Student("Oksana", "Ovsianyk"),
                    new Student("Anna", "Morina"),
                    new Student("Maksym", "Rybalko"),
                    new Student("Ihor", "Shramko"),
                    new Student("Nazar", "Putilovskyi"),
                    new Student("Tymofii", "Stepanchuk"),
                    new Student("Sofia", "Tanchuk"),
                    new Student("Maria", "Yakymchuk"),
                    new Student("Liubomyr", "Gorobiuk"),
                    new Student("Yehor", "Sabadash"),
                    new Student("Dariia", "Khomenko"),
                    new Student("Andrii", "Humyniuk"),
                    new Student("Mykhailo", "Chulii"),
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
                    new Student("Veronika", "Honcharenko"),
                    new Student("Artem","Kudryavtsev"),
                    new Student("Bogdana","Mosiyevich"),
                    new Student("Denys", "Maiko"),
                    new Student("Bohdan","Kovalenko"),
                    new Student("Yaroslav", "Sagun"),
                    new Student("Vlad", "Bakunets"),
                    new Student("Anna", "Tverdokhlib"),
                    new Student("Volodymyr", "Karnaushko"),
                    new Student("Tanya", "Chervinska")
                    }.ToImmutableList()
                },
            }
        .ToImmutableDictionary();
    }

    public IReadOnlyDictionary<GroupNumber, ImmutableList<Student>> Students => _students;
}
