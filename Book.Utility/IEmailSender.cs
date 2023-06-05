namespace Book.Utility
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string v1, string v2);
    }
}