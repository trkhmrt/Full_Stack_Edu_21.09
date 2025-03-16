using E_Commerce.Business.Dto;
using E_Commerce.Business.Dto.requestDtos;
using E_Commerce.Business.Interface;
using E_Commerce.DataAccess.Context;
using E_Commerce.DataAccess.Model;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Business.Service;

public class UserService: IUserService
{
    ProjectContext _context;
    
    public UserService(ProjectContext context)
    {
        _context = context;
    }

    public ICollection<UserDto> GetAllUsers()
    {
        var users =  _context.Users
            .Include(u=>u.UserRoles)
            .ThenInclude(ur=>ur.Role)
            .Select(u=> new UserDto
            {
                userId = u.userId,
                userName = u.userName,
                email = u.email,
                firstName = u.firstName,
                kullaniciRolu = u.UserRoles.Select(ur=> new RoleDto
                {
                   roleName = ur.Role.roleName
                }).ToList()
            }).ToList();


        return users;


    }

    public UserDto GetUserByUsernameAndPassword(AuthLoginRequest loginRequest)
    {
        var user =  _context.Users
            .Include(u=>u.UserRoles)
            .ThenInclude(ur=>ur.Role)
            .Where(u=>u.userName == loginRequest.username && u.password == loginRequest.password)
            .Select(u=> new UserDto
            {
                userId = u.userId,
                userName = u.userName,
                email = u.email,
                firstName = u.firstName,
                kullaniciRolu = u.UserRoles.Select(ur=> new RoleDto
                {
                    roleName = ur.Role.roleName
                }).ToList()
            }).FirstOrDefault();

        
        return user; 
    }
 
    
}



