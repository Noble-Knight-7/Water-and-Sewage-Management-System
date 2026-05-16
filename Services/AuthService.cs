using WaterSewageManagementSystem.DataAccess;
using WaterSewageManagementSystem.Helpers;
using WaterSewageManagementSystem.Models;

namespace WaterSewageManagementSystem.Services
{
    // AuthService handles login and registration logic.
    // It sits between the LoginForm (UI) and UserRepository (database).
    // The form asks AuthService, AuthService asks the repository, and returns the result.
    public class AuthService
    {
        private readonly UserRepository _userRepo;

        public AuthService()
        {
            _userRepo = new UserRepository();
        }

        // Login: Check email + password, if correct store user in session
        public bool Login(string email, string password)
        {
            User user = _userRepo.GetByEmail(email);
            if (user == null) return false;
            if (user.Status != "Active") return false;
            if (!PasswordHelper.Verify(password, user.Password)) return false;

            SessionManager.Login(user);
            return true;
        }

        // Register: Create a new user account
        public bool Register(User user)
        {
            // Check if email is already taken
            if (_userRepo.EmailExists(user.Email)) return false;

            // Employees (non-customers) start as Pending until Admin approves
            if (user.Role != "Customer")
                user.Status = "Pending";
            else
                user.Status = "Active";

            return _userRepo.Insert(user);
        }

        public void Logout()
        {
            SessionManager.Logout();
        }
    }
}
