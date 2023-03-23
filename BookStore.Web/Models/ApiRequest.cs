using static BookStore.Web.SD;

namespace BookStore.Web.Models
{
    public class ApiRequest
    {
        public ApiType ApiTipe { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; }
    }
}
