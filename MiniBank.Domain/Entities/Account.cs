using System.ComponentModel.DataAnnotations;

namespace MiniBank.Domain.Entities
{
    public class Account
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        
        [Required]
        public string CustomerName { get; set; } = null!;
    }
}
