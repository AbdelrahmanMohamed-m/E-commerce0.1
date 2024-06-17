using System.ComponentModel.DataAnnotations.Schema;


namespace api.DataLayer.Entities
{
    public class Payment
    {

        public int PaymentId { get; set; }

        public String PaymentMethod { get; set; } = "";

        public DateTime PaymentDate { get; set; } = DateTime.Now;

        [Column(TypeName = "decimal(18, 2)")]
        public decimal PaymentAmount { get; set; } = 0;
        public List<Order> Order { get; set; } = [];
    }
}