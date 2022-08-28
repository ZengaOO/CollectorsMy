namespace CollectorsMy.Models
{
    public class PagePhoneModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}