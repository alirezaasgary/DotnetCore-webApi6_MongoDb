namespace FlightPlanAPI.Authentication
{
    public interface IUserService
    {
        Task<User> Authenticate(string username, string password);
    }
}
