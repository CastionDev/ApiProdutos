using System.ComponentModel.DataAnnotations;

namespace CrudFronteiraTec.DTOs
{
    public class ProductDto
    {
        [Required]
        public string Nome { get; set; }

        [MaxLength(200)]
        public string Descricao { get; set; }

        [Range(0.01, 999999)]
        public decimal Preco { get; set; }

        public int Quantidade { get; set; }
    }
}