﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade
{
    public enum UserType
    {
        Admin,
        Manager,
        Employee
    }

    public interface IUserInfo
    {
        UserType UserType
        { get; }

        EntityId Id
        { get; }
    }
        
}