
using System.Net.Http.Headers;

namespace vulrenable_api_with_https.MessageHandlers
{
    public class SessionIdHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            Console.WriteLine("Manipulating Request");
            var headers = request.Content?.Headers;
            
            if (headers != null)
            {
                foreach (var header in headers)
                {
                    Console.WriteLine(header);
                }
            }
            HttpResponseMessage response = await base.SendAsync(request, cancellationToken);

            

            return response;
        }
    }
}
