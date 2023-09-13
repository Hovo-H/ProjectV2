using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;

namespace WebApplication1.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
