﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Director:BaseEntity
    {
        public string DirectorName { get; set; }

        public virtual List<Movie> Movies { get; set; }
    }
}
