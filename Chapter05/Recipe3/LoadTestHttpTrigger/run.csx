using System.Net;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
    System.Threading.Thread.Sleep(2000);
    return req.CreateResponse(HttpStatusCode.OK, "Hello ");
}