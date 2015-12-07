using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade
{
    //public delegate void PassPhone(Phone phone);
    //public delegate void PassPhoneId(Phone phoneId);

    public interface IReadOnlyPhoneService
    {
        //queries
        IPhone GetById(String phoneId);
        IReadOnlyCollection<IPhone> GetAll();
        IReadOnlyCollection<IPhone> GetByDepartmentId(String departmentId);
        IReadOnlyCollection<IPhone> GetByEmployeeId(String employeeId);

        //notifications

        //event PassPhone PhoneCreated;
        //event PassPhone PhoneUpdated;
        //event PassPhoneId PhoneDeleted;
    }
}
