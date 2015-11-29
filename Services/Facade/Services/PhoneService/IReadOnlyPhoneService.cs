using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade.Services.PhoneService
{
    public delegate void PassPhone(Phone phone);
    public delegate void PassPhoneId(Phone phoneId);

    public interface IReadOnlyPhoneService
    {
        //queries
        Phone GetById(EntityId phoneId);
        IReadOnlyCollection<Phone> GetAll();
        IReadOnlyCollection<Phone> GetByDepartmentId(EntityId departmentId);
        IReadOnlyCollection<Phone> GetByEmployeeId(EntityId employeeId);

        //notifications
        event PassPhone EmployeeCreated;
        event PassPhone EmployeeUpdated;
        event PassPhoneId EntityDeleted;
    }
}
