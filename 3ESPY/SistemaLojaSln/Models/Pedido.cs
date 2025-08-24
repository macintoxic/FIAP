using System.ComponentModel.DataAnnotations.Schema;

namespace LojaSystem.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        
        public DateTime DataPedido { get; set; }
        
        [Column(TypeName = "decimal(12,2)")]
        public decimal ValorTotal { get; set; }
        
        public string Status { get; set; } = "Pendente";
        
        // Foreign Key
        public int ClienteId { get; set; }
        
        // Navigation Property - Many-to-One
        public Cliente Cliente { get; set; }
        
        // Navigation Property - One-to-Many
        public ICollection<ItemPedido> ItensPedido { get; set; } = new List<ItemPedido>();
    }
}