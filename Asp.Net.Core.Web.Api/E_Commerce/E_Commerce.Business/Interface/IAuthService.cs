using E_Commerce.Business.Dto;
using E_Commerce.Business.Dto.requestDtos;

namespace E_Commerce.Business.Interface;

public interface IAuthService
{
    AuthLoginResponse login(AuthLoginRequest authLoginRequest);
    AuthLoginResponse customerLogin(AuthLoginRequest authLoginRequest);
}