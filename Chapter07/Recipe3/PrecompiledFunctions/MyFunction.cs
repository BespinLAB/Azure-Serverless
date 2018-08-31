using System.Net;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
namespace PreCompiledFunctions
{
public class MyFunction
    {
    public static async Task<HttpResponseMessage>
    MyRun(HttpRequestMessage req)
        {
            // parse query parameter
            string name = req.GetQueryNameValuePairs()
            .FirstOrDefault(q => string.Compare(q.Key, "name", true) == 0).Value;
            dynamic data = await
            req.Content.ReadAsAsync<object>();
            name = name ?? data?.name;
            return name == null
            ? req.CreateResponse(HttpStatusCode.BadRequest,
            "Please pass a name on the query string or in the request body") : req.CreateResponse
            (HttpStatusCode.OK, "Hello " + name);
        }
    }
}