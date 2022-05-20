using System.ComponentModel.DataAnnotations;
namespace web_api_db.Models
{

    public class Mapa
    {
        [Key]

        public int id { get; set; }

        public string Nombre { get; set; }

        public double Latitud { get; set; }

        public double Longitud { get; set; }


    }
}