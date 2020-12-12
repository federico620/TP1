using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP1.Models
{
    public class Hallazgo
    {
        public TimeSpan HoraHallazgo { get; set; }

        public int CantidadHallazgo { get; set; }

        public Defecto Defecto { get; set; }

        public pie Pie { get; set; }

        public Hallazgo(TimeSpan hh, Defecto d,pie p)
        {
            HoraHallazgo = hh;
            CantidadHallazgo = 0;
            Defecto = d;
            Pie = p;
        }

        public Hallazgo(TimeSpan hh,pie p)
        {
            HoraHallazgo = hh;
            Pie = p;
            CantidadHallazgo = 0;
        }

        public void AgregarHallazgo()
        {
            CantidadHallazgo++;
        }
    }

}