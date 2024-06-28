using AllianceDeploy.Model;
using Newtonsoft.Json;
using System;
using System.IO;

namespace AllianceDeploy.Data
{
    public class LeerJson
    {
        private string configFilePath;
        public CambiosPedidos Config { get; private set; }

        public LeerJson()
        {
            configFilePath = Path.Combine(FileSystem.AppDataDirectory, "CambiosPedido.json");
            CopiarArchivoJson();
            LoadConfiguration();
        }

        private void CopiarArchivoJson()
        {
            // Ruta del archivo en el proyecto
            string sourceFile = Path.Combine(AppContext.BaseDirectory, "Data", "CambiosPedido.json");
            Console.WriteLine("Ruta del archivo fuente: " + sourceFile);
            Console.WriteLine("Ruta del archivo destino: " + configFilePath);
            if (File.Exists(sourceFile))
            {
                File.Copy(sourceFile, configFilePath, true);
                Console.WriteLine("Archivo JSON copiado a: " + configFilePath);
            }
            else
            {
                Console.WriteLine("El archivo JSON fuente no existe.");
            }
        }

        private void LoadConfiguration()
        {
            try
            {
                if (File.Exists(configFilePath))
                {
                    string configJson = File.ReadAllText(configFilePath);
                    Config = JsonConvert.DeserializeObject<CambiosPedidos>(configJson);
                }
                else
                {
                    Console.WriteLine("El archivo JSON no existe.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar la configuración: " + ex.Message);
            }
        }
    }
}
