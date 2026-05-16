using WaterSewageManagementSystem.Models;

namespace WaterSewageManagementSystem.Helpers
{
    // SessionManager is a static class that remembers who is logged in.
    // Think of it like a "memory" for the whole application.
    // Once a user logs in, their info is stored here and can be read from any form.
    public static class SessionManager
    {
        public static User CurrentUser { get; private set; }

        public static void Login(User user)
        {
            CurrentUser = user;
        }

        public static void Logout()
        {
            CurrentUser = null;
        }

        public static bool IsLoggedIn()
        {
            return CurrentUser != null;
        }

        public static bool IsAdmin()
        {
            return CurrentUser?.Role == "Admin";
        }

        public static bool IsCustomer()
        {
            return CurrentUser?.Role == "Customer";
        }

        public static bool IsServiceOfficer()
        {
            return CurrentUser?.Role == "ServiceOfficer";
        }

        public static bool IsMaintenanceEngineer()
        {
            return CurrentUser?.Role == "MaintenanceEngineer";
        }
    }
}
