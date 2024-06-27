using Microsoft.Maui.Controls;
using Mopups.Pages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace AllianceDeploy.View
{
    public partial class historialCambiosPage : PopupPage
    {

        double _translationY;

        public historialCambiosPage()
        {
            InitializeComponent();
            LoadJsonData();
        }

        private async Task LoadJsonData()
        {
            try
            {
                // Obtener la ruta completa al archivo JSON usando AppContext.BaseDirectory
                string basePath = AppContext.BaseDirectory;
                string jsonPath = Path.Combine(basePath, "CambiosPedido.json");

                // Imprimir la ruta completa para depuración
                Console.WriteLine($"Ruta al archivo JSON: {jsonPath}");

                // Leer el archivo JSON
                var jsonString = await File.ReadAllTextAsync(jsonPath);

                // Deserializar el JSON con JSON.NET
                var datos = JsonConvert.DeserializeObject<JsonData>(jsonString);

                // Vincular datos al ListView
                VersionesListView.ItemsSource = datos.Versiones;
            }
            catch (Exception ex)
            {
                // Manejo de errores: puedes mostrar un mensaje al usuario o registrar el error
                 Console.WriteLine($"Error al cargar y parsear el archivo JSON: {ex.Message}");
            }
        }


        void OnPanUpdated(object sender, PanUpdatedEventArgs e)
        {

        }

        private void Cerrar_Clicked(object sender, EventArgs e)
        {
            // Implementa la lógica para cerrar el popup cuando se hace clic en el botón de cerrar
            // Puedes usar PopAsync() o similar para cerrar el popup en función de tu configuración de navegación
        }
    }

    public class VersionData
    {
        public string Version { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public List<string> Cambios { get; set; }
    }

    public class JsonData
    {
        public List<VersionData> Versiones { get; set; }
    }
}
