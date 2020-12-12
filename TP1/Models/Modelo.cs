using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP1.Models
{
    public class Modelo
    {
        public string Sku { get; set; }

        public string Denominacion { get; set; }

        public int Objetivo { get; set; }

        public Modelo(string sku, string d, int o)
        {
            Sku = sku;
            Denominacion = d;
            Objetivo = o;
        }
    }
}