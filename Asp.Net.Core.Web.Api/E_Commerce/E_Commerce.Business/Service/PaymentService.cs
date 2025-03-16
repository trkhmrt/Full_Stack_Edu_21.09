using E_Commerce.Business.Dto;
using E_Commerce.Business.Interface;
using E_Commerce.DataAccess.Context;
using E_Commerce.DataAccess.Model;

namespace E_Commerce.Business.Service;

public class PaymentService : IPaymentService
{
    ProjectContext _context;
    IBasketService _basketService;

    public PaymentService(ProjectContext context, IBasketService basketService)
    {
        _context = context;
        _basketService = basketService;
    }

    public PaymentResponseDto createPayment(int basketId)
    {
        
        using (var transaction = _context.Database.BeginTransaction())
        {
            try
            {
                BasketResponseDto basketResponse = _basketService.getBasketByBasketId(basketId);
                if (basketResponse != null)
                {
                    Payment payment = new Payment
                    {
                        basketId = basketResponse.basketId,
                        customerId = basketResponse.basketCustomerId,
                        totalQuantity = basketResponse.basketDetails.Sum(bd => bd.basketQuantity),
                        totalAmount = basketResponse.basketDetails.Sum(bd => bd.productPrice * bd.basketQuantity),
                        paymentStatusId = 1
                    };


                    _context.Payments.Add(payment);
                    _context.SaveChanges();
                    
                    Order order = new Order
                    {
                        basketId = basketResponse.basketId,
                        customerId = basketResponse.basketCustomerId,
                        orderDate = DateTime.Now,
                        totalAmount = payment.totalAmount,
                        orderStatusId = 1,
                    };


                    _context.Orders.Add(order);
                    _context.SaveChanges();
                    
                    List<OrderDetail> orderDetails_list = new List<OrderDetail>();
                    foreach (var item in basketResponse.basketDetails)
                    {
                        OrderDetail orderDetail = new OrderDetail
                        {
                            order_product_quantity = item.basketQuantity,
                            order_product_totalPrice = item.productPrice * item.basketQuantity,
                            productId = item.productId,
                            orderId = order.orderId,
                        };
                        orderDetails_list.Add(orderDetail);
                    }



                    _basketService.statusBasketToOrder(basketId);
                    _context.OrderDetails.AddRange(orderDetails_list);
                    _context.SaveChanges();

                    transaction.Commit();

                    return new PaymentResponseDto
                    {
                        orderId = order.orderId,
                        paymentMessage = "Success"
                    };



                }
            }
            catch (Exception e)
            {
                transaction.Rollback();
                Console.WriteLine("Transaction failed" + e.Message);
            }
        }

        return new PaymentResponseDto
        {
            paymentMessage = "Failed"
        };

    }
}