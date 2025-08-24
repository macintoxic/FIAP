using System.ComponentModel.DataAnnotations;

namespace LojaSystem.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }
        
        public string Descricao { get; set; }
        
        // Navigation Property - One-to-Many
        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();
    }
}