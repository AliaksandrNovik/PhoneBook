using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BLL
{
    public class Identified
    {
        public Identified()
        {            
            this.Id = Guid.NewGuid().ToString("N");
        }

        [JsonConstructor]
        public Identified(string id)
        {
            this.Id = id;
        }

        public string Id
        { get; private set; }
    }
}
