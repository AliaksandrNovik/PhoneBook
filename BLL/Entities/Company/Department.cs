using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Repositories
{
    public class Department : Identified
    {
        internal Department(string name, string parentId):
            base()
        {
            this.Name = name;
            this.ParentId = parentId;
        }

        [JsonConstructor]
        internal Department(string id, string name, string parentId) :
            base(id)
        {
            this.Name = name;
            this.ParentId = parentId;
        }

        public string Name
        { get; set; }        

        public string ParentId
        { get; set; }        
    }
}
