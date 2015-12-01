using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    //interface for Alex.BestDevelperEver
    interface IRepository
    {
        Department CreateDepartment();//args
        bool UpdateDepartment(Department department);
        bool DeleteDepartment(Department department);

        Employee CreateEmployee();//args
        bool UpdateEmployee(Employee employee);
        bool DeleteEmployee(Employee employee);

        Phone CreatePhone();
        bool UpdatePhone(Phone phone);
        bool DeletePhone(Phone phone);
    }
}
