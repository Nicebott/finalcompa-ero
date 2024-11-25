using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace INF512_FinalProject
{
    public class RepositorioEstudiantes
    {
        private readonly string archivo = "estudiantes.txt";

        public void GuardarEstudiante(Estudiante estudiante)
        {
            string data = $"{estudiante.Matricula},{estudiante.Nombre},{estudiante.Apellido}," +
                         $"{string.Join(";", estudiante.Examenes)},{string.Join(";", estudiante.Practicas)}," +
                         $"{estudiante.CalificacionFinal},{estudiante.Estatus}";
            File.AppendAllText(archivo, data + Environment.NewLine);
        }

        public List<Estudiante> CargarEstudiantes()
        {
            List<Estudiante> estudiantes = new List<Estudiante>();

            if (File.Exists(archivo))
            {
                var lineas = File.ReadAllLines(archivo);
                foreach (var linea in lineas)
                {
                    var partes = linea.Split(',');
                    if (partes.Length >= 5)
                    {
                        var examenes = partes[3].Split(';').Select(double.Parse).ToArray();
                        var practicas = partes[4].Split(';').Select(double.Parse).ToArray();

                        Estudiante estudiante = new Estudiante
                        {
                            Matricula = partes[0],
                            Nombre = partes[1],
                            Apellido = partes[2],
                            Examenes = examenes,
                            Practicas = practicas,
                        };

                        estudiante.CalcularCalificacionFinal();
                        estudiantes.Add(estudiante);
                    }
                }
            }

            return estudiantes;
        }
    }
}
