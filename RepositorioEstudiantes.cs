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
            try
            {
                string practicas = string.Join(";", estudiante.Practicas ?? new double[3]);
                string examenes = string.Join(";", estudiante.Examenes ?? new double[3]);

                string data = $"{estudiante.Matricula},{estudiante.Nombre},{practicas},{examenes},{estudiante.CalificacionFinal:F2},{estudiante.Estatus}";

                // Si el estudiante ya existe, lo actualizamos
                if (File.Exists(archivo))
                {
                    var lineas = File.ReadAllLines(archivo).ToList();
                    var index = lineas.FindIndex(l => l.StartsWith(estudiante.Matricula + ","));
                    if (index >= 0)
                    {
                        lineas[index] = data;
                        File.WriteAllLines(archivo, lineas);
                        return;
                    }
                }

                // Si no existe, lo agregamos al final
                File.AppendAllText(archivo, data + Environment.NewLine);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar estudiante: {ex.Message}");
            }
        }

        public void EliminarEstudiante(string matricula)
        {
            try
            {
                if (File.Exists(archivo))
                {
                    var lineas = File.ReadAllLines(archivo);
                    var nuevasLineas = lineas.Where(l => !l.StartsWith(matricula + ",")).ToList();
                    File.WriteAllLines(archivo, nuevasLineas);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar estudiante: {ex.Message}");
            }
        }

        public List<Estudiante> CargarEstudiantes()
        {
            List<Estudiante> estudiantes = new List<Estudiante>();

            try
            {
                if (File.Exists(archivo))
                {
                    var lineas = File.ReadAllLines(archivo);
                    foreach (var linea in lineas)
                    {
                        if (string.IsNullOrWhiteSpace(linea)) continue;

                        var partes = linea.Split(',');
                        if (partes.Length >= 4)
                        {
                            var practicas = new double[3];
                            var examenes = new double[3];

                            // Cargar prácticas
                            if (!string.IsNullOrEmpty(partes[2]))
                            {
                                var practicasStr = partes[2].Split(';');
                                for (int i = 0; i < Math.Min(practicasStr.Length, 3); i++)
                                {
                                    double.TryParse(practicasStr[i], out practicas[i]);
                                }
                            }

                            // Cargar exámenes
                            if (!string.IsNullOrEmpty(partes[3]))
                            {
                                var examenesStr = partes[3].Split(';');
                                for (int i = 0; i < Math.Min(examenesStr.Length, 3); i++)
                                {
                                    double.TryParse(examenesStr[i], out examenes[i]);
                                }
                            }

                            var estudiante = new Estudiante
                            {
                                Matricula = partes[0],
                                Nombre = partes[1],
                                Practicas = practicas,
                                Examenes = examenes
                            };

                            estudiante.CalcularCalificacionFinal();
                            estudiantes.Add(estudiante);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al cargar estudiantes: {ex.Message}");
            }

            return estudiantes;
        }
    }
}