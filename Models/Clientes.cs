using System.ComponentModel.DataAnnotations;
namespace web_api_db.Models{

    public class Clientes{
        [Key]

        public int id_cliente{get;set;}

        public string nit{get;set;}

        public string nombre{get;set;}

        public string apellido{get;set;}

        public string direccion{get;set;}

        public string telefono{get;set;}

        public string fecha_nacimiento{get;set;}
    }
}