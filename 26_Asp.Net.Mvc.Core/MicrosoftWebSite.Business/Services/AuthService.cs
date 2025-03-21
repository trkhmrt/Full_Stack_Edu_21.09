using Microsoft_WebSite.DataAccess;
using Microsoft_WebSite.DataAccess.Entities;
using MicrosoftWebSite.Business.Dtos;
using MicrosoftWebSite.Business.Interfaces;

namespace MicrosoftWebSite.Business.Services;

public class AuthService : IAuthService
{
    private Microsoft_Website_Context _context;


    public AuthService(Microsoft_Website_Context context)
    {
        _context = context;
    }

    public User SignIn(LoginDto loginDto)
    {
        var founded_user = _context.Users.FirstOrDefault(u =>
            u.UserUsername == loginDto.userName && u.UserPassword == loginDto.userPassword);

        
        
        return founded_user;
        
        
    }

    public void SignUp(SignUpDto signUpDto)
    {
        User new_user = new User()
        {
            UserUsername = signUpDto.userName,
            UserPassword = signUpDto.userPassword,
            UserEmail = signUpDto.userEmail,
            userRole = "Admin"
        };
        
        _context.Users.Add(new_user);
        _context.SaveChanges();



    }
}