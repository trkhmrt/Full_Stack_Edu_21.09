namespace E_Commerce.DataAccess.Model;

public class Payment
{
    public int paymentId { get; set; }

    public int customerId { get; set; }
    public Customer Customer { get; set; }
    
    public int basketId { get; set; }
    public Basket Basket { get; set; }

    public int totalQuantity { get; set; }
    public int totalAmount { get; set; }

    public int paymentStatusId { get; set; }
    public PaymentStatus PaymentStatus { get; set; }
    
    
         
           
}