namespace Events.Demo_1___BasicEvents;

public class TextMessageService
{
    public void OnVideoEncoded(object source, EventArgs e)
    {
        Console.WriteLine("TextMessageService: Sending a text message... ");
    }
}