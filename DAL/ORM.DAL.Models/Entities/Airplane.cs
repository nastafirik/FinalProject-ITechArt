﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.DAL.Models.Entities {
    public class Airplane : IBaseEntity<long> {

        public long Id { get; set; }

        public string Type { get; set; }

    }
}
