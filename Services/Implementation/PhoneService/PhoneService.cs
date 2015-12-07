using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Facade;
using BLL.Repository;

namespace Services.Implementation.PhoneService
{
    public class PhoneService : IPhoneService
    {
        private IPhoneRepository _repository = new PhoneRepository();
        public IPhone CreatePhone(string number, string departmentId = null, string employeeId = null)
        {
            var repPhone = _repository.CreatePhone(number, departmentId, employeeId);
            return new Phone(repPhone.PhoneNumber, repPhone.EmployeeId, repPhone.DepartmentId, repPhone.Id);
        }

        public bool DeletePhone(string phoneId)
        {
            return _repository.DeletePhone(phoneId);
        }

        public IReadOnlyCollection<IPhone> GetAll()
        {
            List<IPhone> phones = new List<IPhone>();
            foreach (var repPhone in _repository.GetAllPhones())
            {
                phones.Add(new Phone(repPhone.PhoneNumber, repPhone.EmployeeId, repPhone.DepartmentId, repPhone.Id));
            }

            return phones;
        }

        public IReadOnlyCollection<IPhone> GetByDepartmentId(string departmentId)
        {
            return GetAll().Where(x => x.DepartmentId == departmentId).ToList();
        }

        public IReadOnlyCollection<IPhone> GetByEmployeeId(string employeeId)
        {
            return GetAll().Where(x => x.EmployeeId == employeeId).ToList();
        }

        public IPhone GetById(string phoneId)
        {
            var repPhone = _repository.GetPhoneById(phoneId);
            if (repPhone != null)
            {
                return new Phone(repPhone.PhoneNumber, repPhone.EmployeeId, repPhone.DepartmentId, repPhone.Id);
            }
            else
            {
                return null;
            }
                
        }

        public bool UpdatePhone(IPhone phone)
        {
            var repPhone = _repository.GetPhoneById(phone.Id);
            if (repPhone != null)
            {
                repPhone.PhoneNumber = phone.Number;
                repPhone.DepartmentId = phone.DepartmentId;
                repPhone.EmployeeId = phone.EmployeeId;
                return _repository.UpdatePhone(repPhone);
            }
            else
            {
                return false;
            }
        }
    }
}
