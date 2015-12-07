using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository
{ 
    public class PhoneRepository : IPhoneRepository
    {
        private FileRepository<Phone> _fileRepository = new FileRepository<Phone>("Phone.txt");
        public IReadOnlyCollection<Phone> GetAllPhones()
        {
            return _fileRepository.GetAll();
        }

        public Phone GetPhoneById(string phoneId)
        {
            return _fileRepository.GetById(phoneId);
        }

        public Phone CreatePhone(string number, string departmentId, string employeeId)
        {
            var phone = new Phone(number, departmentId, employeeId);
            _fileRepository.Upsert(phone);
            return phone;
        }

        public bool UpdatePhone(Phone phone)
        {
            bool canUpdate = (_fileRepository.GetById(phone.Id) != null);
            if (canUpdate)
            {
                _fileRepository.Upsert(phone);
            }
            return canUpdate;
        }

        public bool DeletePhone(string phoneId)
        {
            return _fileRepository.Delete(phoneId);
        }
    }
}
