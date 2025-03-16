using E_Commerce.Business.Dto;
using E_Commerce.Business.Dto.requestDtos;

namespace E_Commerce.Business.Interface;

public interface ICustomerService
{
    GeneralResponse createCustomer(CreateCustomerRequest request);
    bool getCustomerByEmailPhoneUsername(string email,string phone,string username);
}