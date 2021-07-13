using Lab1_bobrivnyk.Rest.Models;

namespace Lab1_bobrivnyk.Rest.DTOs
{
    public class AuthenticateResponse
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string JwtToken { get; set; }
    }

}
