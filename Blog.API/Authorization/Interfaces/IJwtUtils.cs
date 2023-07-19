using Blog.API.Entities;

namespace Blog.API.Authorization.Interfaces
{
    public interface IJwtUtils
    {
        public string GenerateToken(User user);
        public int? ValidateToken(string token);
    }
}
