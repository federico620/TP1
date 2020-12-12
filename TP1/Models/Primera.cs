using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP1.Models
{
    public class Primera
    {
        public TimeSpan HoraPrimera { get; set; }

        public int CantidadPrimera { get; set; }

        public Primera(TimeSpan hp)
        {
            HoraPrimera = hp;
            CantidadPrimera = 0;
        }

        public void AgregarPrimera()
        {
            CantidadPrimera++;
        }
    }

    
}