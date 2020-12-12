using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP1.Models
{
    public class SupervisorDeLinea : Empleado
    {
        public List<OP> OPs { get; set; }

        public OP CrearOP()
        {
           var OP = new OP();
           return OP;
        }

        public void ConfirmarOP(OP op,Modelo m,Color c,Linea l,string n)
        {
            op.ConfirmarOP(m, c, l, n);
            OPs.Add(op);
        }
    }
}