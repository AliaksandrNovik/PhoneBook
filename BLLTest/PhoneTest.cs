using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using BLL;

namespace BLLTest
{
    [TestClass]
    public class PhoneTest
    {
        [TestMethod]
        public void Phone_SimpleInit()
        {
            string number = "+333-72-73";
            var phone = new Phone(number);
            Assert.AreEqual(phone.Department, null, "Department isn't null");
            Assert.AreEqual(phone.Owner, null, "Owner isn't null");
            Assert.AreEqual(phone.PhoneNumber, number.Clone(), "Number isn't the passed");
        }

        [TestMethod]
        public void Phone_DepartmentInit()
        {
            var department = new Department();
            string number = "1";
            var phone = new Phone(number, department);
            Assert.AreEqual(phone.Department, new Department(), "Check");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "A employee without department cannot posses phone.")]
        public void Phohe_EmployeeWithoutDepartmentInit()
        {
            var employee = new Employee();
            var phone = new Phone("777-77", employee);
        }
    }
}
