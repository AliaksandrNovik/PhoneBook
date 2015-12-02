using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Department : Identified
    {
        internal Department(string name, string parentId)
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
