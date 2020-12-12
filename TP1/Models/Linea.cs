using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP1.Models
{
    public class Linea
    {

        public int NumeroLinea { get; set; }
       
        public Linea(int n)
        {
            NumeroLinea = n;
        }
    }
}