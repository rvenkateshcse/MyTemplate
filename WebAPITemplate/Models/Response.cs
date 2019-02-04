using Newtonsoft.Json;

namespace WebAPITemplate.Models
{
    public class Response
    {
        public bool Status { get; set; }
        public string Message { get; set; }

        public Response(bool status, string message)
        {
            Status = status;
            Message = message;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}