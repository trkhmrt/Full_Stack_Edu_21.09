using E_Commerce.Business.Dto;

namespace E_Commerce.Business.Interface;

public interface IPaymentService
{
    PaymentResponseDto createPayment(int basketId);
}