﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Azure.Management.V2.Network
{
    public interface IBackend
    {
        string Name { get; set; }
    }

    public interface IInboundNatPool
    {
        string Name { get; set; }
    }
}
