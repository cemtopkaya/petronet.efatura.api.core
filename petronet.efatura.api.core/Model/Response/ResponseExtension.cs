using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace petronet.efatura.api.core.Model.Response
{

    public static class ResponseExtension
    {
        public static IActionResult ToHttpResponse<TModel>(this IListResponse<TModel> response)
        {
            HttpStatusCode oK = HttpStatusCode.OK;
            if (response.DidError)
            {
                oK = HttpStatusCode.InternalServerError;
            }
            else if (response.Model == null)
            {
                oK = HttpStatusCode.NotFound;
            }
            ObjectResult result1 = new ObjectResult(response);
            result1.StatusCode = (new int?((int)oK));
            return result1;
        }

        public static IActionResult ToHttpResponse<TModel>(this ISingleResponse<TModel> response)
        {
            HttpStatusCode oK = HttpStatusCode.OK;
            ObjectResult result = new ObjectResult(response);
            if (response.DidError)
            {
                oK = HttpStatusCode.InternalServerError;
            }
            else if (response.Model == null)
            {
                oK = HttpStatusCode.NotFound;
            }
            ObjectResult result1 = new ObjectResult(response);
            result1.StatusCode = (new int?((int)oK));
            return result1;
        }

        public static IActionResult ToHttpResponse(this Response response)
        {
            HttpStatusCode code = response.DidError ? HttpStatusCode.InternalServerError : HttpStatusCode.OK;
            ObjectResult result1 = new ObjectResult(response);
            result1.StatusCode = (new int?((int)code));
            return result1;
        }
    }
}
