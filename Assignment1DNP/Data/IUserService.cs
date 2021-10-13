using Models;


namespace Assignment1DNP.Data
{
    public interface IUserService
    {
        User ValidateUser(string username, string password);
    }
}