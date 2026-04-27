using System.ComponentModel.DataAnnotations;

namespace CrudFronteiraTec.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [MaxLength(200)]
        public string Descricao { get; set; }

        [Range(0.01, 999999)]
        public decimal Preco { get; set; }

        public int Quantidade { get; set; }
    }
}