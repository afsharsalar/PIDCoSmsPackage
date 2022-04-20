using System.Net;

namespace PIDCoSmsPackage.Model
{
    public class ApiResultModel<T>
    {
        public HttpStatusCode Status { get; set; }


        public T Data { get; set; }
    }
}
