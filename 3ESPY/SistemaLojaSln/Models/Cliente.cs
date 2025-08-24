using System.ComponentModel.DataAnnotations;

namespace LojaSystem.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(150)]
        public string Nome { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [StringLength(15)]
        public string Telefone { get; set; }
        
        public DateTime DataCadastro { get; set; }
        
        // Navigation Property - One-to-Many
        public ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
        
        // Navigation Property - One-to-One
        public Perfil Perfil { get; set; }
    }
}