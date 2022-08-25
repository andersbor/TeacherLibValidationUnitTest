using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherLibValidationUnitTEst
{
    public static class TeacherValidator
    {
        public static void ValidateSalary(int salary)
        {
            if (salary < 0)
                throw new ArgumentOutOfRangeException("Salary must be at least 0: " + salary);
        }

        public static void ValidateName(string? name)
        {
            if (name == null)
                throw new ArgumentNullException("name is null");
            if (name.Length < 1)
                throw new ArgumentException("name must be at least 1 character");
        }

        public static void Validate(Teacher teacher)
        {
            ValidateSalary(teacher.Salary);
            ValidateName(teacher.Name);
        }
    }
}
