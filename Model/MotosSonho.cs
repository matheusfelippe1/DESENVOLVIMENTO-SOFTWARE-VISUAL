using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Motocicleta.Model
{
    public class MotosSonho
    {
        /*
        * * {
            "Id":1,
           "Modelo":"Hornet",
            "Marca":"Honda",
            "Ano":"2015",
            "Cilindradas":"600c",
            "Quilometragem":35000
       }*/
        [Key]
        public int Id { get; set; }
        [Required]
        public string Modelo { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string Ano { get; set; }
        public string Cilindradas { get; set; }
        public double Quilometragem { get; set; }

        public MotosSonho()
        { 
        }

        public MotosSonho(string modelo, string marca, string ano)
        {
            this.Modelo = modelo;
            this.Marca = marca;
            this.Ano = ano;
        }
    }
}
