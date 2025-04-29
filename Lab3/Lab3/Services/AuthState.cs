using Microsoft.AspNetCore.Mvc;

namespace Lab3.Services
{
    public class AuthState
    {
        public bool IsAuthenticated { get; set; } = false;
        public string Username { get; set; } = "";
        public string Role { get; set; } = ""; // Optional: for authorization
    }
}
