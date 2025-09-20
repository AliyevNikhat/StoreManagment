namespace OnlineStore.Models.Entities
{
    public class SmtpOptions
    {
        public string Server { get; set; }
        public int Port { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string FromName { get; set; }
    }
}