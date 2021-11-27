using System;
namespace Hackaton.App.Dominio{
    public class Entidades{
        public int id { get; set; }
        public string razon_social { get; set; }
        public string nit { get; set; }
        public string direccion { get; set; }
        public string ciudad{ get; set; }
        public string telefono { get; set; }
        public string webpage {get; set;}
        public Sectores sector {get; set;}
        public Servicios servicio {get; set;}

    }
 
}
