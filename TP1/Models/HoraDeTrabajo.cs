using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP1.Models
{
    public class HoraDeTrabajo
    {
        public DateTime fecha { get; set; }

        public TimeSpan HoraInicio { get; set; }

        public TimeSpan HoraFin { get; set; }

        public List<Primera> Primeras { get; set; }

        public List<Hallazgo> Hallazgos { get; set; }

        public HoraDeTrabajo()
        {
            Primeras = new List<Primera>();
            Hallazgos = new List<Hallazgo>();
        }

        public HoraDeTrabajo(TimeSpan f, List<Defecto> Defectos)
        {
            Primeras = new List<Primera>();
            Hallazgos = new List<Hallazgo>();

            HoraInicio = DateTime.Now.TimeOfDay;
            HoraFin = f;
            fecha = DateTime.Now;

            
            for (int i = HoraInicio.Hours; i <= HoraFin.Hours; i++)
            {
                
                
                TimeSpan ts = new TimeSpan(i,0,0);
                

                var p = new Primera(ts);
                Primeras.Add(p);

                foreach (Defecto d in Defectos)
                {
                    var hi = new Hallazgo(ts,d, pie.Izquierdo);
                    var hd = new Hallazgo(ts,d, pie.Derecho);

                    Hallazgos.Add(hi);
                    Hallazgos.Add(hd);
                }

            }
        }

        public void AgregarPrimera(TimeSpan hs)
        {
            foreach (Primera p in Primeras)
            {
                if(p.HoraPrimera.Hours == hs.Hours)
                {
                    p.AgregarPrimera();
                }
            }
        }

        public void AgregarHallazgo(TimeSpan hs, Defecto d, TipoDefecto tp,pie p)
        {
            foreach(Hallazgo h in Hallazgos)
            {
                if(h.HoraHallazgo.Hours == hs.Hours && h.Defecto == d && h.Pie == p && h.Defecto.TipoDefecto == tp)
                {
                    h.AgregarHallazgo();
                }
            }
        }

        public int ObtenerPrimerasHora(TimeSpan h)
        {
            int cantidad = 0;
            foreach (Primera p in Primeras)
            {
                if (p.HoraPrimera.Hours == h.Hours)
                {
                    cantidad = p.CantidadPrimera;
                }
                
            }

            return cantidad;
        }

        public int ObtenerPrimerasHora(TimeSpan hs, Defecto d, TipoDefecto tp, pie p)
        {
            int cantidad = 0;
            foreach (Hallazgo h in Hallazgos)
            {
                if (h.HoraHallazgo.Hours == hs.Hours && h.Defecto == d && h.Defecto.TipoDefecto == tp && h.Pie == p)
                {
                    cantidad = h.CantidadHallazgo;
                }

            }

            return cantidad;
        }


    }
}