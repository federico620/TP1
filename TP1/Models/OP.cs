using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP1.Models
{
    public class OP
    {
        public string Numeroop { get; set; }
       
        public DateTime FechaInicio { get; set; }
       

        public DateTime FechaFin { get; set; }
        
        public Linea Linea { get; set; }

        public Modelo Modelo { get; set; }

        public Color Color { get; set; }

        public List<HoraDeTrabajo> HoraDeTrabajos { get; set; }

        public Estado Estado { get; set; }

        public OP()
        {
            HoraDeTrabajos = new List<HoraDeTrabajo>();
        }

        public void ConfirmarOP(Modelo m,Color c,Linea l,string n)
        {
            Modelo = m;
            Color = c;
            Linea = l;
            Numeroop = n;
            Estado = Estado.EnProceso;
            FechaInicio = DateTime.Now;
        }

        public void AgregarHDT(HoraDeTrabajo h)
        {
            HoraDeTrabajos.Add(h);
        }

        public void IniciarInspeccion(Turno t, List<Defecto> Defectos)
        {
            var h = new HoraDeTrabajo(t.HoraFinTurno,Defectos);
            HoraDeTrabajos.Add(h);
        }

        public void AgregarPrimera(TimeSpan hs)
        {
            var ht = HoraDeTrabajos.Last();
            ht.AgregarPrimera(hs);
        }

        public void AgregarHallazgo(TimeSpan hs,Defecto d,TipoDefecto tp,pie p)
        {
            var ht = HoraDeTrabajos.Last();
            ht.AgregarHallazgo(hs, d, tp, p);
        }

        public int ObtenerPrimerasHora(TimeSpan h)
        {
           var ht = HoraDeTrabajos.Last();
           return ht.ObtenerPrimerasHora(h);
        }

        public int ObtenerHallazgoHora(TimeSpan hs, Defecto d, TipoDefecto tp, pie p)
        {
            var ht = HoraDeTrabajos.Last();
            return ht.ObtenerPrimerasHora(hs,d,tp,p);
        }
    }
}