using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP1.Models
{
    public class Color
    {
        public int Codigo { get; set; }

        public string Descripcion { get; set; }

        public Color(int c,string d)
        {
            Codigo = c;
            Descripcion = d;
        }
    }
}