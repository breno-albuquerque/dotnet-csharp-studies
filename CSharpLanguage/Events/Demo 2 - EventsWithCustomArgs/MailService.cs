namespace Events.EventsWithCustomArgs;

public class MailService
{
    public void OnVideoEncoded(object source, VideoEventArgs e)
    {
        Console.WriteLine($"MailService: Sending an email. Video: {e.Video.Title}");
    }
}