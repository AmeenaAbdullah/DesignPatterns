

namespace bridgePatterns.Implementation
{
    public class MailSender: IMessageSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending email ... : {message}");
        }
    }
}
