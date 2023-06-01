﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Entiteti
{
    public class VilenjakZaIsporukuPoklona : Vilenjak
    {
        public virtual Tovar Tovar { get; set; }//
        public virtual IList<SpojVilenjakZaIsporukuVestina> VilenjakZaIsporukuVestinaSpoj { get; set; }

        public VilenjakZaIsporukuPoklona() : base()
        {
            VilenjakZaIsporukuVestinaSpoj = new List<SpojVilenjakZaIsporukuVestina>();
        }

    }
}

