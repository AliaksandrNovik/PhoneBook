using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    // I means interface
    public interface IPhoneRepository
    {
        IReadOnlyCollection<Phone> GetAllPhones();
        Phone GetPhoneById(string phoneId);
        Phone CreatePhone(string number, string departmentId, string employeeId);
        bool UpdatePhone(Phone phone);
        bool DeletePhone(string phoneId);
    }
}
