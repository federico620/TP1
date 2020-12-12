using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP1.Models
{
    public class Defecto
    {
        public string DescripcionDefecto { get; set; } 

        public TipoDefecto TipoDefecto { get; set; }

        public Defecto(string dd, TipoDefecto td)
        {
            DescripcionDefecto = dd;
            TipoDefecto = td;
        }
    }
}