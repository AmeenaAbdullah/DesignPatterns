
using bridgePatterns;
using bridgePatterns.Implementation;


namespace bridgePatterns
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("hello");
            Notifier notifier = new Notifier(new MailSender());
            notifier.Notify("It's 7pm, Go to Gym.");

            notifier.ChangeMessageSender(new SkypeSender());
            notifier.Notify("Don't forget to call John at 5pm.");
        }
    }
}