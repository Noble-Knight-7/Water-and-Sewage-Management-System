using System.Collections.Generic;
using WaterSewageManagementSystem.DataAccess;
using WaterSewageManagementSystem.Helpers;
using WaterSewageManagementSystem.Models;

namespace WaterSewageManagementSystem.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepo;
        public UserService() { _userRepo = new UserRepository(); }

        public List<User> GetAllUsers() => _userRepo.GetAll();
        public List<User> GetEngineers() => _userRepo.GetByRole("MaintenanceEngineer");
        public User GetByID(int id) => _userRepo.GetByID(id);

        public bool UpdateProfile(User user) => _userRepo.Update(user);

        public bool ChangePassword(int userID, string oldPassword, string newPassword)
        {
            var user = _userRepo.GetByID(userID);
            if (user == null) return false;
            if (!PasswordHelper.Verify(oldPassword, user.Password)) return false;
            return _userRepo.UpdatePassword(userID, newPassword);
        }

        public bool ActivateUser(int userID) => _userRepo.UpdateStatus(userID, "Active");
        public bool DeactivateUser(int userID) => _userRepo.UpdateStatus(userID, "Inactive");
        public bool ApproveEmployee(int userID) => _userRepo.UpdateStatus(userID, "Active");

        public List<User> GetPendingEmployees()
        {
            var all = _userRepo.GetAll();
            var pending = new List<User>();
            foreach (var u in all)
                if (u.Status == "Pending" && u.Role != "Customer")
                    pending.Add(u);
            return pending;
        }
    }
}
