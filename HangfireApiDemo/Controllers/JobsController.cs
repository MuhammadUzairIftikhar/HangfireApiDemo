using Microsoft.AspNetCore.Mvc;
using Hangfire;

[ApiController]
[Route("api/[controller]")]
public class JobsController : ControllerBase
{
    [HttpPost("schedule")]
    public IActionResult ScheduleJob()
    {
        // Schedule a background job.
        BackgroundJob.Enqueue(() => Console.WriteLine("Hello from Hangfire!"));

        return Ok("Job has been scheduled.");
    }
}
