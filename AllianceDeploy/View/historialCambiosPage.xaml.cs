using AllianceDeploy.Data;
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
        private LeerJson _leerJson;
        public historialCambiosPage()
        {
            InitializeComponent();
            _leerJson = new LeerJson();
            LoadConfiguration();
        }

        private void LoadConfiguration()
        {
            try
            {
                if (_leerJson.Config != null)
                {
                    // Usa _leerJson.Config para acceder a los datos deserializados
                    var cambios = _leerJson.Config;
                    // Aquí puedes actualizar la UI con los datos de cambios
                }
                
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
                Console.WriteLine("Error al cargar la configuración: " + ex.Message);
            }
        }
    }
}
