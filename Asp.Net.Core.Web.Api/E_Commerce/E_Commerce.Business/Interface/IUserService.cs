using E_Commerce.Business.Dto;
using E_Commerce.Business.Dto.requestDtos;
using E_Commerce.Business.Service;
using E_Commerce.DataAccess.Model;

namespace E_Commerce.Business.Interface;

public interface IUserService
{
    ICollection<UserDto> GetAllUsers();
    
    UserDto GetUserByUsernameAndPassword(AuthLoginRequest loginRequest);
    
}