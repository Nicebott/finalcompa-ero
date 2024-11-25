using System;
using System.Linq;

namespace INF512_FinalProject
{
    public class Estudiante
    {
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public double[] Examenes { get; set; }
        public double[] Practicas { get; set; }
        public double CalificacionFinal { get; private set; }
        public string Estatus { get; private set; }

        public void CalcularCalificacionFinal()
        {
            double promedioExamenes = 0;
            double promedioPracticas = 0;

            if (Examenes != null && Examenes.Length > 0)
            {
                promedioExamenes = Examenes.Average();
            }

            if (Practicas != null && Practicas.Length > 0)
            {
                promedioPracticas = Practicas.Average();
            }

            CalificacionFinal = (promedioExamenes * 0.6) + (promedioPracticas * 0.4);
            DeterminarEstatus();
        }

        private void DeterminarEstatus()
        {
            Estatus = CalificacionFinal >= 70 ? "Aprobado" : "Reprobado";
        }
    }
}