﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class UserProfile:BaseEntity
    {
        public string FirstName { get; set; }

        public virtual AppUser AppUser { get; set; }
    }
}
