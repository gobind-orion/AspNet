using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RansomwareTest.Model;
using System.Xml;
using Microsoft.AspNetCore.Hosting;

namespace RansomwareTest.Controllers
{
    public class RansomwareTestController : Controller
    {
        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment _hostingEnvironment;

        public RansomwareTestController(Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        /// <summary>
        /// Save record for ransomware details.
        /// </summary> //Gobind 
        /// <param name="planDetails"></param>
        /// <returns>Message for saved record</returns>

        [HttpPost]
        [Route("SaveRansomwareDetails")]
        public IActionResult SaveRansomwareDetails([FromBody] PlanDetails planDetails)
        {
            var jsonString = JsonConvert.SerializeObject(planDetails, Newtonsoft.Json.Formatting.Indented);
            string contentRootPath = _hostingEnvironment.ContentRootPath;
            System.IO.File.WriteAllText(contentRootPath + "/Data/Data.json", jsonString);
            return Ok();
        }


    }
}
