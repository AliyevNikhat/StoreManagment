namespace OnlineStore.Services.Validation.Mail
{
    public interface IMailSender
    {
        Task SendAsyn(string toMail, string subject, string body);
    } 
}