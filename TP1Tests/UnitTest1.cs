using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP1.Models;

namespace TP1Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AgregarUnParAPrimera()
        {
            // arrange

            var OP = new OP();
            List<Defecto> Defectos = new List<Defecto>();

            TimeSpan hi = DateTime.Now.TimeOfDay;
            TimeSpan hf = new TimeSpan(hi.Hours + 2, 0, 0);

            var Turno = new Turno(hi, hf);

            TimeSpan hp1 = new TimeSpan(hi.Hours + 1, 32, 0);

            OP.IniciarInspeccion(Turno,Defectos);
            OP.AgregarPrimera(hp1);

            // act

            var respuesta = OP.ObtenerPrimerasHora(hp1);


            // assert

            Assert.AreEqual(1, respuesta);
        }

        [TestMethod]
        public void AgregarDefectoPieIzquierdoObservado()
        {
            // arrange

            var OP = new OP();
            List<Defecto> Defectos = new List<Defecto>();

            Defecto d = new Defecto("Descosido", TipoDefecto.Observado);
            Defectos.Add(d);

            TimeSpan hi = DateTime.Now.TimeOfDay;
            TimeSpan hf = new TimeSpan(hi.Hours + 2, 0, 0);

            var Turno = new Turno(hi, hf);

            TimeSpan hp1 = new TimeSpan(hi.Hours + 1, 32, 0);

            OP.IniciarInspeccion(Turno, Defectos);
            OP.AgregarHallazgo(hp1, d, d.TipoDefecto, pie.Izquierdo);

            // act

            var respuesta = OP.ObtenerHallazgoHora(hp1, d, d.TipoDefecto, pie.Izquierdo);

            // assert

            Assert.AreEqual(1, respuesta);
        }

        [TestMethod]
        public void IniciarInspeccionConHoraInicioActualHoraFinMasTres()
        {
            // arrange

            var OP = new OP();
            List<Defecto> Defectos = new List<Defecto>();

            TimeSpan hi = DateTime.Now.TimeOfDay;
            TimeSpan hf = new TimeSpan(hi.Hours + 3, 0, 0);

            var Turno = new Turno(hi, hf);


            // act

            OP.IniciarInspeccion(Turno, Defectos);
            var h = OP.HoraDeTrabajos.Last();
            var respuesta = h.HoraFin.Hours;
            // assert

            Assert.AreEqual(hi.Add( new TimeSpan(3,0,0)).Hours, respuesta);
        }
    }
}
