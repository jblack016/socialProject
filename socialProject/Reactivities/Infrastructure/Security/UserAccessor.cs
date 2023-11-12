
using System.Security.Claims;
using Application.Interfaces;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Security
{
    public class UserAccessor : IUserAccessor
    {
        private readonly IHttpContextAccessor _httpcontextAccessor;
        public UserAccessor(IHttpContextAccessor httpContextAccessor)
        {
            _httpcontextAccessor = httpContextAccessor;
        }
        public string GetUsername()
        {
            return _httpcontextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);
        }
    }
}