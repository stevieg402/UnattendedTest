using System.Web.Mvc;

namespace UnattendedTest.Controllers
{
    /// <summary>
    /// Class which models the error controller
    /// </summary>
    public class ErrorController : Controller
    {
        // GET: Error/NotFound
        /// <summary>
        /// Returns the NotFound view
        /// </summary>
        /// <returns>A <see cref="ActionResult"/> object</returns>
        public ActionResult NotFound()
        {
            return View();
        }

        // GET: Error/BadRequest
        /// <summary>
        /// Returns the BadRequest view
        /// </summary>
        /// <returns>A <see cref="ActionResult"/> object</returns>
        public ActionResult BadRequest()
        {
            return View();
        }
    }
}