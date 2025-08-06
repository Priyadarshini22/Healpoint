using healpoint.Model.PatientModel;

namespace healpoint.Services
{
    public interface ITokenService
    {
        public Task<string> GenerateToke(LoginRequestDTO loginRequest);
    }
    public class TokenService : ITokenService
    {
        public Task<string> GenerateToke(LoginRequestDTO loginRequest)
        {
            var a = "dsds";
            return Task.FromResult(a);
        }
    }
}
