﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edgeShop.Models
{
    internal abstract class BaseDTO
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }

    }
}
