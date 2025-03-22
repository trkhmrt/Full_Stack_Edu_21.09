using E_Commerce.Business.Dto;
using E_Commerce.Business.Dto.requestDtos;
using E_Commerce.Business.Interface;
using E_Commerce.DataAccess.Context;
using E_Commerce.DataAccess.Model;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Business.Service;

public class CustomerService:ICustomerService
{
    ProjectContext _context;


    public CustomerService(ProjectContext context)
    {
        _context = context;
    }
    
    public GeneralResponse createCustomer(CreateCustomerRequest request)
    {
        var result = getCustomerByEmailPhoneUsername(request.customerEmail, request.customerPhoneNumber,
            request.customerUserName);

        if (result)
        {
            return new GeneralResponse()
            {
                message = $"böyle bir kayıt zaten var.Eğer şifrenizi unuttuysanız Şifre sıfırlayabilirsiniz."
            };
        }
        else
        {
            Customer newCustomer = new Customer()
            {
                customerUserName = request.customerUserName,
                customerFirstName = request.customerFirstName,
                customerLastName = request.customerLastName,
                customerEmail = request.customerEmail,
                customerAddress = request.customerAddress,
                customerPassword = request.customerPassword,
                customerPhoneNumber = request.customerPhoneNumber,
                roleId = 2
            };
        
            _context.Customers.Add(newCustomer);
            _context.SaveChanges();

            return new GeneralResponse()
            {
                message = $"{newCustomer.customerUserName} created successfully."
            };
        }
        
    }

    public bool getCustomerByEmailPhoneUsername(string email, string phone, string username)
    {
        
       var foundCustomer = _context.Customers.Where(c => c.customerEmail == email || c.customerUserName == username || c.customerPhoneNumber==phone).FirstOrDefault();

       if (foundCustomer != null)
       {
           return true;
       }
       return false;
    }

    public CustomerResponse GetCustomerByUsernameAndPassword(AuthLoginRequest authLoginRequest)
    {
        var customer =  _context.Customers
            .Include(c=>c.Role)
            .ThenInclude(ur=>ur.Customers)
            .Where(c=>c.customerUserName == authLoginRequest.username && c.customerPassword == authLoginRequest.password)
            .Select(c=> new CustomerResponse
            {
                customerId = c.customerId,
                customerUserName = c.customerUserName,
                customerMail = c.customerEmail,
                customerFirstname = c.customerFirstName,
                customerRolu = new CustomerRoleDto
                {
                    customerRoleName = c.Role.roleName
                }
            }).FirstOrDefault();

        
        return customer; 
    }
}