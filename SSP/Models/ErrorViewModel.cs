namespace SSP.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }
        public string? ControllerName { get; set; }
        public string? ActionName { get; set; }
        public string? ErrorMessage { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}