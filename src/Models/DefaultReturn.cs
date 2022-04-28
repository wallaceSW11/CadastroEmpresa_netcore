namespace ISS.Models
{
    public class DefaultReturn
    {
        public string Status { get; set; }
        public string Message { get; set; }

        public DefaultReturn(string status, string message)
        {
            Status = status;
            Message = message;
        }

    }
}