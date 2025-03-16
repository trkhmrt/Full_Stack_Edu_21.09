using E_Commerce.DataAccess.Model;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace E_Commerce.Business.Dto;

public class AuthLoginResponse
{
    public string username { get; set; }
    public string accessToken { get; set; }
    public string message { get; set; }
}