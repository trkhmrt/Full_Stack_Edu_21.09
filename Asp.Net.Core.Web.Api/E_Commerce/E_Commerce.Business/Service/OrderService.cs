using E_Commerce.Business.Dto;
using E_Commerce.Business.Interface;
using E_Commerce.DataAccess.Context;
using E_Commerce.DataAccess.Model;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Business.Service;

public class OrderService:IOrderService
{
    ProjectContext _context;


    public OrderService(ProjectContext context)
    {
        _context = context;
    }
    
    
    public ICollection<OrderResponseDto> getAllOrders()
    {
        return _context.Orders
            .Include(o=>o.Customer)
            .Include(o=>o.OrderDetails)
            .ThenInclude(o=>o.Product)
            .Include(o=>o.OrderStatus).ToList()
            .Select(o=> new OrderResponseDto
            {
                orderId = o.orderId,
                orderDate = o.orderDate,
                totalAmount = o.totalAmount,
                customerUserName = o.Customer.customerUserName,
                orderStatusName = o.OrderStatus.orderStatusName,
                orderDetails = o.OrderDetails.Select(o=> new OrderDetailsResponseDto
                {
                    orderProductQuantity = o.order_product_quantity,
                    orderProductTotalPrice = o.order_product_totalPrice,
                    productName = o.Product.productName,
                    
                }).ToList()
            }).ToList();
    }

    public ICollection<OrderResponseDto> getAllOrdersByCustomerId(int customerId)
    {
        return _context.Orders
            .Include(o=>o.Customer)
            .Include(o=>o.OrderDetails)
            .ThenInclude(o=>o.Product)
            .Include(o=>o.OrderStatus).ToList()
            .Where(o=>o.Customer.customerId == customerId)
            .Select(o=> new OrderResponseDto
            {
                orderId = o.orderId,
                orderDate = o.orderDate,
                totalAmount = o.totalAmount,
                customerUserName = o.Customer.customerUserName,
                orderStatusName = o.OrderStatus.orderStatusName,
                orderDetails = o.OrderDetails.Select(o=> new OrderDetailsResponseDto
                {
                    orderProductQuantity = o.order_product_quantity,
                    orderProductTotalPrice = o.order_product_totalPrice,
                    productName = o.Product.productName,
                    
                }).ToList()
            }).ToList();
    }

    public OrderResponseDto getOrderByOrderId(int orderId)
    {
        return _context.Orders
            .Include(o=>o.Customer)
            .Include(o=>o.OrderDetails)
            .ThenInclude(o=>o.Product)
            .Include(o=>o.OrderStatus).ToList()
            .Where(o=>o.orderId == orderId)
            .Select(o=> new OrderResponseDto
            {
                orderId = o.orderId,
                orderDate = o.orderDate,
                totalAmount = o.totalAmount,
                customerUserName = o.Customer.customerUserName,
                orderStatusName = o.OrderStatus.orderStatusName,
                orderDetails = o.OrderDetails.Select(o=> new OrderDetailsResponseDto
                {
                    orderProductQuantity = o.order_product_quantity,
                    orderProductTotalPrice = o.order_product_totalPrice,
                    productName = o.Product.productName,
                    
                }).ToList()
            }).FirstOrDefault();
    }

    public void cancelOrderByOrderId(int orderId)
    {
        var foundedOrder = _context.Orders.FirstOrDefault(o => o.orderId == orderId);

        if (foundedOrder != null)
        {
            foundedOrder.orderStatusId = 2;
            _context.SaveChanges();
        }
        else
        {
             throw new Exception($"Order with id {orderId} not found"); 
        }
        
    }
   
    public void completeOrderByOrderId(int orderId)
    {
        var foundedOrder = _context.Orders.FirstOrDefault(o => o.orderId == orderId);

        if (foundedOrder != null)
        {
            foundedOrder.orderStatusId = 6;
            _context.SaveChanges();
        }
        else
        {
            throw new Exception($"Order with id {orderId} not found"); 
        }
        
    }

    public void toCargoOrderByOrderId(int orderId)
    {
        var foundedOrder = _context.Orders.FirstOrDefault(o => o.orderId == orderId);

        if (foundedOrder != null)
        {
            foundedOrder.orderStatusId = 3;
            _context.SaveChanges();
        }
        else
        {
            throw new Exception($"Order with id {orderId} not found"); 
        }
    }

    public void approveOrderByOrderId(int orderId)
    {
        var foundedOrder = _context.Orders.FirstOrDefault(o => o.orderId == orderId);

        if (foundedOrder != null)
        {
            foundedOrder.orderStatusId = 4;
            _context.SaveChanges();
        }
        else
        {
            throw new Exception($"Order with id {orderId} not found"); 
        }
    }

    public void deliveredOrderByOrderId(int orderId)
    {
        var foundedOrder = _context.Orders.FirstOrDefault(o => o.orderId == orderId);

        if (foundedOrder != null)
        {
            foundedOrder.orderStatusId = 5;
            _context.SaveChanges();
        }
        else
        {
            throw new Exception($"Order with id {orderId} not found"); 
        }
    }
}