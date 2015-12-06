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
        Department createDepartment();//args
        bool updateDepartment(Department department);
        bool deleteDepartment(Department department);

        Employee createEmployee();//args
        bool updateEmployee(Employee employee);
        bool deleteEmployee(Employee employee);

        Phone createPhone();
        bool updatePhone(Phone phone);
        bool deletePhone(Phone phone);
    }
}
