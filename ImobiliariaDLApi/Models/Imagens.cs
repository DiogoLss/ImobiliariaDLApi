using System.ComponentModel.DataAnnotations;

namespace ImobiliariaDLApi.Models
{
    public class Imagem
    {
        public int Id { get; set; }
        [Required]
        public string ImagemString { get; set; }
        public int ImovelId { get; set; }
        public Imovel Imovel { get; set; }
    }
}
