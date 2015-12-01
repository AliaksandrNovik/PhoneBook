using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repository.Implement.Ent
{
    class Phone
    {
        public Phone(String name, String id)
        {
            this.Name = name;
            this.Id = id;
        }

        public string Id
        { get; private set; }

        public string Name
        { get; set; }

        IReadOnlyCollection<String> SubordinatePhoneIds
        { get; set; }

        String ParentPhoneId
        { get; set; }
    }
}
