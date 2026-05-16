namespace WaterSewageManagementSystem.Helpers
{
    // PasswordHelper handles password operations.
    // For this academic project we store plain text passwords (same as your DB sample data uses "1234").
    // In a real production system you would use bcrypt or SHA256 hashing.
    public static class PasswordHelper
    {
        public static bool Verify(string inputPassword, string storedPassword)
        {
            return inputPassword == storedPassword;
        }
    }
}
