﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    interface ISportsStoreRepository
    {
        IEnumerable<Product> Products { get; }

    }
}