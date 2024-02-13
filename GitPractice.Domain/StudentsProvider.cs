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
                { new GroupNumber("IC-31"), new[]{new Student("Mikita", "Kalachuk") }.ToImmutableList() },
                { new GroupNumber("IC-32"), new[]{new Student("FirstName", "LastName") }.ToImmutableList() },
                { new GroupNumber("IC-33"), new[]{new Student("FirstName", "LastName") }.ToImmutableList() },
                { new GroupNumber("IC-34"), new[]{new Student("FirstName", "LastName") }.ToImmutableList() },
            }
            .ToImmutableDictionary();
        }
    }
}

