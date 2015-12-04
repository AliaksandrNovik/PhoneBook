﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BLL
{
    public class Department : Identified
    {
        [JsonConstructor]
        internal Department(string name, string parentId):
            base()
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
