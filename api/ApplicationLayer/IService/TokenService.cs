
using api.DataLayer.Entities;

namespace api.ControlLayer.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}