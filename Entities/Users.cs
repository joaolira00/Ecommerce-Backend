namespace Entities
{
    public class Users
    {
        private string? username;
        private string? password;
        private string? email;

        public string? GetUsername()
        {
            return username;
        }

        public void SetUsername(string _username)
        {
            username = _username;
        }

        public string? GetPassword()
        {
            return password;
        }

        public void SetPassword(string _password)
        {
            password = _password;
        }

        public string? GetEmail()
        {
            return email;
        }

        public void SetEmail( string _email)
        {
            email = _email;
        }

        
    }
}