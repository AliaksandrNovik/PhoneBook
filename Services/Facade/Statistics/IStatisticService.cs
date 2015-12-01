﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Facade.Statistics
{
    public interface IStatisticService
    {
        IReadOnlyCollection<CallSession> GetByPhoneId(EntityId phoneId);
    }
}