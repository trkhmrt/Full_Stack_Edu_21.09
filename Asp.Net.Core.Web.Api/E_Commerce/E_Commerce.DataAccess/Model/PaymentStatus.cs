namespace E_Commerce.DataAccess.Model;

public class PaymentStatus
{
    
    public int paymentStatusId { get; set; }
    
    public string paymentStatusName { get; set; }
    
    public ICollection<Payment> Payments { get; set; }
}