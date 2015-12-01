using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade
{
    public class PhoneService : IPhoneService
    {
        public event PassPhone PhoneCreated;
        public event PassPhoneId PhoneDeleted;
        public event PassPhone PhoneUpdated;

        public void CreatePhone(string number, EntityId department = null, EntityId employee = null)
        {
            throw new NotImplementedException();
        }

        public void DeletePhone(EntityId phoneId)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<Phone> GetAll()
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<Phone> GetByDepartmentId(EntityId departmentId)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<Phone> GetByEmployeeId(EntityId employeeId)
        {
            throw new NotImplementedException();
        }

        public Phone GetById(EntityId phoneId)
        {
            throw new NotImplementedException();
        }

        public void UpdatePhone(Phone phone)
        {
            throw new NotImplementedException();
        }
    }
}
