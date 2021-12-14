using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using CommandResults;
using Models;
using System;
using System.Linq;
using System.Net;

namespace HomeAnimals.Controllers
{
    /// <summary>
    /// Base Class for APIs
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ApiBase : ControllerBase
    {

        /// <summary>
        /// Get Response based on on Result
        /// </summary>
        /// <typeparam name="TResult">BaseResult</typeparam>
        /// <param name="result">result to convert to response</param>
        /// <returns>Response</returns>
        protected ActionResult<TResult> GetResponseFromResult<TResult>(TResult result) where TResult : BaseResult
        {
            return result.ResponseStatusCode switch
            {
                (HttpStatusCode.OK) => Ok(result),
                // To Get the Proble Details
                (HttpStatusCode.NotFound) => NotFound(result),
                (HttpStatusCode.BadRequest) => BadRequest(result),
                _ => StatusCode((int)result.ResponseStatusCode, result)
            };
        }

        internal string GetVerifyEmailRoute(string id, string token, string portalUrl)
        {
            return $"{portalUrl}/api/Account/verify?id={id}&token={token}";
        }

        internal string GetResetPasswordEmailRoute(string token, string Email, string portalUrl)
        {
            return $"{portalUrl}/account/verifypassword?email={Email}&token={token}";
        }

        internal string GetUserByClaimType(string claimType)
        {
            try
            {
                var claimResult = User.Claims.FirstOrDefault(c => c.Type.Equals(claimType));

                if (claimResult == null)
                    throw new UnauthorizedException("Invalid request");

                if (string.IsNullOrEmpty(claimResult.Value))
                    throw new UnauthorizedException("Invalid request");

                return claimResult.Value;
            }
            catch (UnauthorizedException ex)
            {
#if DEBUG
                Console.WriteLine(ex.Message);
#endif

                throw new UnauthorizedException("Unauthorized");
            }
            catch (Exception ex)
            {
#if DEBUG
                Console.WriteLine(ex.Message);
#endif

                throw ex;
            }
        }

    }
}
