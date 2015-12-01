using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository.Implement.Ent
{
    class ReposPhone : IRepositoryPhone
    {
        private Dictionary<String, Phone> listPhoneId;
        private String numberPhone;

        public Phone getPhonebyId(String id)
        {
            Phone dep;
            listPhoneId.TryGetValue(id, out dep);
            return dep;
        }

        public ReposPhone()
        {
            listPhoneId = new Dictionary<string, Phone>();
        }
        public Phone createPhone(string name, string phoneId, IReadOnlyCollection<string> subDepartmens = null, IReadOnlyCollection<string> employees = null, IReadOnlyCollection<string> phones = null)
        {
            phoneId = Guid.NewGuid().ToString("N"); ;
            Phone templDep = new Phone(name, phoneId);
            listPhoneId.Add(phoneId, templDep);
            return getPhonebyId(phoneId);
        }

        public bool deletePhone(string name, string phoneId, IReadOnlyCollection<string> subDepartmens = null, IReadOnlyCollection<string> employees = null, IReadOnlyCollection<string> phones = null)
        {
            listPhoneId.Remove(phoneId);
            return true;
        }

        public bool updatePhone(string name, string phoneId, IReadOnlyCollection<string> subDepartmens = null, IReadOnlyCollection<string> employees = null, IReadOnlyCollection<string> phones = null)
        {
            return true;
        }
    }
}
