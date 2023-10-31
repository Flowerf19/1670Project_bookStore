using _1670Project.Models.Form;

namespace _1670Project.Repositories.Abstract
{
    public interface IUserAuthenticationService
    {
        Task<Status> LoginAsync(LoginModel model);
        Task LogoutAsync();
        Task<Status> RegisterAsync(RegistrationModel model);

        //Task<Status> ChangePasswordAsync(ChangePasswordModel model, string username);
    }
}
