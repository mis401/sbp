﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entiteti
{
    public class DeteRoditelj
    {
        public virtual int ID { get; set; }
        public virtual string Roditelj { get; set; }
        public virtual Dete Dete { get; set; }

    }
}
