using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeacherLibValidationUnitTEst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherLibValidationUnitTEst.Tests
{
    [TestClass()]
    public class TeacherValidatorTests
    {
        [TestMethod()]
        public void ValidateSalaryTest()
        {
            TeacherValidator.ValidateSalary(0);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => TeacherValidator.ValidateSalary(-1));
        }

        [TestMethod()]
        public void ValidateNameTest()
        {
            TeacherValidator.ValidateName("Y");
            Assert.ThrowsException<ArgumentNullException>(() => TeacherValidator.ValidateName(null));
            Assert.ThrowsException<ArgumentException>(() => TeacherValidator.ValidateName(""));
        }

        [TestMethod()]
        public void ValidateTest()
        {
            Teacher teacher = new Teacher { ID = 1, Name = "Y", Salary = 0 };
            TeacherValidator.Validate(teacher);
        }
    }
}