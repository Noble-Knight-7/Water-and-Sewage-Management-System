using WaterSewageManagementSystem.DataAccess;
using WaterSewageManagementSystem.Helpers;
using WaterSewageManagementSystem.Models;

namespace WaterSewageManagementSystem.Services
{
    public class AuthService
    {
        private readonly UserRepository _userRepo;
        private readonly CustomerRepository _customerRepo;

        public AuthService()
        {
            _userRepo = new UserRepository();
            _customerRepo = new CustomerRepository();
        }

        public bool Login(string email, string password)
        {
            User user = _userRepo.GetByEmail(email);

            if (user == null) return false;
            if (user.Status != "Active") return false;
            if (!PasswordHelper.Verify(password, user.Password)) return false;

            SessionManager.Login(user);
            return true;
        }

        public bool Register(User user)
        {
            if (_userRepo.EmailExists(user.Email))
                return false;

            if (user.Role != "Customer")
                user.Status = "Pending";
            else
                user.Status = "Active";

            bool userInserted = _userRepo.Insert(user);

            if (!userInserted)
                return false;

            if (user.Role == "Customer")
            {
                User insertedUser = _userRepo.GetByEmail(user.Email);

                if (insertedUser == null)
                    return false;

                Customer customer = new Customer
                {
                    UserID = insertedUser.UserID,
                    MeterNumber = "",
                    HoldingNumber = "",
                    ConnectionType = "Residential"
                };

                return _customerRepo.Insert(customer);
            }

            return true;
        }

        public void Logout()
        {
            SessionManager.Logout();
        }
    }
}