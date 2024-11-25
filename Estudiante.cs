using System;
using System.Linq;

namespace INF512_FinalProject
{
    public class Estudiante
    {
        private double[] practicas = new double[3];
        private double[] examenes = new double[3];

        public string Matricula { get; set; }
        public string Nombre { get; set; }

        public double[] Practicas
        {
            get => practicas;
            set
            {
                practicas = new double[3];
                if (value != null)
                {
                    Array.Copy(value, practicas, Math.Min(value.Length, 3));
                }
            }
        }

        public double[] Examenes
        {
            get => examenes;
            set
            {
                examenes = new double[3];
                if (value != null)
                {
                    Array.Copy(value, examenes, Math.Min(value.Length, 3));
                }
            }
        }

        public double CalificacionFinal { get; private set; }
        public string Estatus { get; private set; }

        public void CalcularCalificacionFinal()
        {
            double promedioExamenes = Examenes.Average();
            double promedioPracticas = Practicas.Average();

            CalificacionFinal = Math.Round((promedioExamenes * 0.6) + (promedioPracticas * 0.4), 2);
            DeterminarEstatus();
        }

        private void DeterminarEstatus()
        {
            Estatus = CalificacionFinal >= 70 ? "Aprobado" : "Reprobado";
        }
    }
}