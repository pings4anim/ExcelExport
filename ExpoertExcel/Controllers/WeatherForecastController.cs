using ExpoertExcel.Model;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace ExpoertExcel.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        //[HttpGet(Name = "GetWeatherForecast")]
        //Excel Download
        /// <summary>
        /// Update Segment Display Code 
        /// </summary>
        /// <param name="segmentItemId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet("PersonCsvSample")]
        [Produces("text/csv")]
        [ProducesResponseType(200, Type = typeof(FileContentResult))]
        public async Task<IActionResult> PersonCSVSample()
        {

            // Get the export data from manager
            var headers = typeof(ExcelModelcs)
        .GetProperties()
        .Select(prop => prop.Name)
        .ToArray();

            // ✅ Get ordered properties with DisplayName for header
            var csvContent = string.Join(",", headers);


            var bytes = Encoding.UTF8.GetBytes(csvContent);
            return File(
                bytes,
                "text/csv",
                $"PersonUploadSample.csv"
            );
        }
    }
}
