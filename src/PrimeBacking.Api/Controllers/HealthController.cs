using Microsoft.AspNetCore.Mvc;

namespace PrimeBanking.Api.Controllers
{
    /// <summary>
    /// Controller responsible for handling health check requests and providing the current health status of the application.
    /// </summary>
    [ApiController]
    [Route("health")]
    public class HealthController : ControllerBase
    {
        /// <summary>
        /// Checks the health status of the application.
        /// </summary>
        /// <returns>The current health status.</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<HealthStatus> HealthCheck()
        {
            return Ok(new HealthStatus("Healthy", DateTime.UtcNow));
        }
    }

    /// <summary>
    /// Represents the health status of the application.
    /// </summary>
    /// <param name="Status">The current health status (e.g., "Healthy", "Unhealthy").</param>
    /// <param name="Timestamp">The timestamp when the health status was checked.</param>
    public sealed record HealthStatus(string Status, DateTime Timestamp);
}
