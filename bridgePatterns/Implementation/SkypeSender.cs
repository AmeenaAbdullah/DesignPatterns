namespace bridgePatterns.Implementation
{
    public class SkypeSender: IMessageSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending email ... : {message}");
        }
    }
}
