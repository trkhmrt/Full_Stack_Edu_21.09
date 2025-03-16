using E_Commerce.Business.Dto;
using E_Commerce.Business.Dto.requestDtos;
using E_Commerce.Business.Interface;

namespace E_Commerce.Business.Service;

public class AuthService:IAuthService
{
    IUserService _userService;
    IJwtGenerator _jwtGenerator;

    public AuthService(IUserService userService, IJwtGenerator jwtGenerator)
    {
        _userService = userService;
        _jwtGenerator = jwtGenerator;
    }

    public AuthLoginResponse login(AuthLoginRequest authLoginRequest)
    {
        var userResponse = _userService.GetUserByUsernameAndPassword(authLoginRequest);
        if (userResponse != null)
        {
            var jwtResponse = _jwtGenerator.GenerateToken(userResponse);
            if (jwtResponse != null)
            {
                return new AuthLoginResponse
                {
                    message = "Login Sucess",
                    accessToken = jwtResponse,
                    username = userResponse.userName
                };
            }
        }
        return new AuthLoginResponse
        {
            message = "Password or username incorrect",
        };
    }
}