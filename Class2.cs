using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace formulario_parcial
{
    public static class DataManager
    {
        private const string FileName = "datos.json";

        public static void GuardarDatos(List<Persona> personas)
        {
            try
            {
                List<Persona> personasCargadas = CargarDatos(); // Cargar datos existentes si hay alguno

                // Agregar las nuevas personas a la lista existente
                personasCargadas.AddRange(personas);
                string filePath = Path.Combine(Environment.CurrentDirectory, "datos.json");
                // Serializar la lista de personas actualizada a JSON
                string json = JsonSerializer.Serialize(personasCargadas);
                Console.WriteLine("Ruta del archivo JSON: " + filePath);
                Console.WriteLine("HOLAAAAAAAAA");
                // Guardar el JSON en un archivo
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                // Manejar errores de guardado
                Console.WriteLine("Error al guardar los datos: " + ex.Message);
            }
        }

        public static List<Persona> CargarDatos()
        {
            try
            {
                if (File.Exists(FileName))
                {
                    // Leer el JSON desde el archivo y deserializarlo
                    string json = File.ReadAllText(FileName);
                    List<Persona> personas = JsonSerializer.Deserialize<List<Persona>>(json);
                    return personas;
                }
                else
                {
                    // Si el archivo no existe, devolver una lista vacía
                    return new List<Persona>();
                }
            }
            catch (Exception ex)
            {
                // Manejar errores de carga
                Console.WriteLine("Error al cargar los datos: " + ex.Message);
                return new List<Persona>();
            }
        }
    }
}
