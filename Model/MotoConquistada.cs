using System.ComponentModel.DataAnnotations;

namespace Motocicleta.Model
{
    /*
    * * {
       "Id":2,
        "Nome":"Hornet",
        "DataConquistada":"07/09/2022",
        "ValorPago":31000,
        "QuitadaOuFinanciada": true 
   }
   */
    public class MotoConquistada
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public string DataConquistada { get; set; }
        public double ValorPago { get; set; }
        public bool QuitadaOuFinanciada { get; set; }

        public MotoConquistada()
        {
        }

        public MotoConquistada(string nome)
        {
            this.Nome = nome;
        }
    }
}
