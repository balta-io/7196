namespace Todo.Api.Models
{
    public class Token
    {
        public string Email { get; set; }
        public string EmailVerified { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public string Locale { get; set; }
        public string Exp { get; set; }
    }

}