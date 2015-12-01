using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Identified
    {
        public Identified()
        {
            this.Id = Guid.NewGuid().ToString("N");
        }

        public string Id
        { get; private set; }
    }
}
