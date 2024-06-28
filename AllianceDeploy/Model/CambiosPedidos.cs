using System;
using System.Collections.Generic;

namespace AllianceDeploy.Model
{
    public class CambiosPedidos
    {
        public string NombreApp { get; set; }
        public string TipoApp { get; set; }
        public List<VersionInfo> Versiones { get; set; }
    }

    public class VersionInfo
    {
        public string Version { get; set; }
        public string FechaLanzamiento { get; set; }
        public List<string> Cambios { get; set; }
    }
}
