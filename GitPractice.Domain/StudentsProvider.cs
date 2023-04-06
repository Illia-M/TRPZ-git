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
                    new Student("Datsenko","Anastasiia"),
                    new Student("Delita", "Diana"),
                    new Student("Melnyk", "Sofia"),
                    new Student("Hai", "Dmytro"),
                    new Student("Daria", "Polishchuk"),
                    new Student("Andrew", "Kachalov"),
                    new Student("Bohdan", "Zaskaleta"),
                    new Student("Yevhenii","Ihnatkin"),
                    new Student("Sofia","Bielchik"),
                    new Student("Artem","Vinnytskyi"),
                    new Student("Anatoliy", "Adamenko"),
                    new Student("Alina", "Tokarska"),
                    new Student("Andrey", "Kostiuk"),
		    new Student("Demych", "Serhii"),
                    new Student("Serhii", "Baibikov"),
                    new Student("Overchenko", "Volodymyr"),
                }.ToImmutableList() },
                { new GroupNumber("IC-22"), new[]{
                    new Student("Maxym", "Shapoval"),
                    new Student("Dania", "Holovach"),
                    new Student("Masha", "Larina"),
                    new Student("Maxim", "Grinevich"),
                    new Student("Roman", "Denysiuk"),
                    new Student("Nazar", "Udod"),
                    new Student("Leonid", "Oliinyk"),
                    new Student("Maxim", "Lemish"),
                    new Student("Anastasiya", "Stoliarcuk"),
                    new Student("Oleksii", "Prokopishyn"),
                    new Student("Nikita", "Rahmanov"),
                    new Student("Lesya", "Vashchyshyna"),
                    new Student("Ann", "Shvetsova"),
                    new Student("Bohdan", "Zhytchenko"),
                    new Student("Denys", "Slyva"),
                    new Student("Vitalii", "Mandrika"),
                    new Student("Pavlo", "Tkachuk")
                }.ToImmutableList() },
                { new GroupNumber("IC-23"), new[]{
                    new Student("Katya", "Myronets"),
                    new Student("Artem", "Leschenko"),
                    new Student("Pavlo", "Ovsyuk"),
                    new Student("Bogdan", "Gilevich"),
                    new Student("Kirill", "Nesterenko"),
                    new Student("Yana", "Pron"),
                    new Student("Yaroslav", "Dobrutskiy"),
                    new Student("Oleksandr", "Vershyhora"),
                    new Student("Sofia", "Kotsiubynska"),
                    new Student("Dmytro", "Nifontov"),
                    new Student("Vadim", "Matok"),
                    new Student("Artem","Matok"),
                    new Student("Illia","Rak"),
                }.ToImmutableList() },
            }
        .ToImmutableDictionary();
    }
}
