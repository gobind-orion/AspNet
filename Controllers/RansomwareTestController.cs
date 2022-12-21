using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RansomwareTest.Model;

namespace RansomwareTest.Controllers
{
    /// <summary>
    /// RansomwareTest Controller 
    /// api/[Controller] on RansomwareTest becomes api/RansomwareTest
    /// endpoint: "api/RansomwareTest" from [Controller] and name of controller , which is "RansomwareTest"
    /// </summary>
    [Route("api/[Controller]")]
    public class RansomwareTestController : Controller
    {
        /// <summary>
        /// private field to store reference of IHostingEnvironment
        /// </summary>
        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment _hostingEnvironment;

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="hostingEnvironment"></param>
        public RansomwareTestController(Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        /// <summary>
        /// Save record for ransomware details
        /// </summary> //Gobind 
        /// <param name="planDetails"></param>
        /// <returns>Message for saved record</returns>

        [HttpPost]
        [Route("SaveRansomwareDetails")]
        public IActionResult SaveRansomwareDetails([FromBody] PlanDetails planDetails)
        {
           // Serialize the request object 
            var jsonString = JsonConvert.SerializeObject(planDetails, Newtonsoft.Json.Formatting.Indented);

            // Retriving contentpath for the application
            string contentRootPath = _hostingEnvironment.ContentRootPath;

            // write the searilize object into json file
            System.IO.File.WriteAllText(contentRootPath + "/Data/Data.json", jsonString);
            return Ok();
        }


    }
}
