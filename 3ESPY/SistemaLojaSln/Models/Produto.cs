using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaSystem.Models
{
    public class Produto
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(200)]
        public string Nome { get; set; }
        
        [Column(TypeName = "decimal(10,2)")]
        public decimal Preco { get; set; }
        
        public int EstoqueAtual { get; set; }
        
        public DateTime DataCadastro { get; set; }
        
        // Foreign Key
        public int CategoriaId { get; set; }
        
        // Navigation Property - Many-to-One
        public Categoria Categoria { get; set; }
        
        // Navigation Property - One-to-Many (para ItemPedido)
        public ICollection<ItemPedido> ItensPedido { get; set; } = new List<ItemPedido>();
    }
}