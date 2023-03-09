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
                { new GroupNumber("IC-21"), new[]{new Student("FirstName", "LastName") }.ToImmutableList() },
                { new GroupNumber("IC-22"), new[]{new Student("FirstName", "LastName") }.ToImmutableList() },
             
                { new GroupNumber("IC-23"), new[]{new Student("Pavlo", "Ovsyuk") }.ToImmutableList() },
                
            }
            .ToImmutableDictionary();
        }
    }
}

