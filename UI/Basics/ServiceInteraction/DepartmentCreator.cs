using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Facade;

namespace UI.Basics
{
    class DepartmentCreator
    {
        public static Department CreateRootDepartment(IReadOnlyDepartmentService departmentService,
            IReadOnlyEmployeeService employeeService, IReadOnlyPhoneService phoneService)
        {
            return null;
        }

        public static Department CreateDepartment(IReadOnlyDepartmentService departmentService,
            IReadOnlyEmployeeService employeeService, IReadOnlyPhoneService phoneService,
            Services.Facade.String rootDepartment)
        {
            //todo
            return null;
        }

    }
}
