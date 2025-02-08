using Microsoft_WebSite.DataAccess.Entities;
using MicrosoftWebSite.Business.Dtos;

namespace MicrosoftWebSite.Business.Interfaces;

public interface IAuthService
{
    User SignIn(LoginDto loginDto);
}