﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCP_ET.API.Interfaces
{
    public interface IEntityReference
    {
        IEntity Entity { get; set; }
    }
}
