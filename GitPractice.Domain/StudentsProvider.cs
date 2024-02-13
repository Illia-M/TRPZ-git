using System;
using System.Collections.Immutable;

namespace TRPZ_git
{
    public class StudentsProvider
    {
        private ImmutableDictionary<GroupNumber, ImmutableList<Student>> _students;

        public StudentsProvider()
        {
            _students = new Dictionary<GroupNumber, ImmutableList<Student>>()
            {
IC-31-Oleh-Lobko
                { new GroupNumber("IC-31"), new[]{new Student("Oleksandr", "Sychov"), new Student("Mikita", "Kalachuk"),new Student("Oleh", "Lobko") }.ToImmutableList() },
stream/IC-3x
                { new GroupNumber("IC-32"), new[]{new Student("FirstName", "LastName") }.ToImmutableList() },
                { new GroupNumber("IC-33"), new[]{new Student("FirstName", "LastName") }.ToImmutableList() },
                { new GroupNumber("IC-34"), new[]{new Student("FirstName", "LastName") }.ToImmutableList() },
                
            }
            .ToImmutableDictionary();
        }
    }
}

