namespace AgustusBackend.Controller
{
    using BusinessLogic;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public class SuggestionsController : ApiController
    {
        public HttpResponseMessage GetRestaurants()
        {
            return Request.CreateResponse(HttpStatusCode.OK, Gourmet.GetMostRecommended());
        }
    }
}
