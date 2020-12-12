using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP1.Models
{
    public class Turno
    {

        public TimeSpan HoraInicioTurno { get; set; }

        public TimeSpan HoraFinTurno { get; set; }


        public Turno(TimeSpan i,TimeSpan f)
        {
            HoraInicioTurno = i;
            HoraFinTurno = f;
        }
    }
}