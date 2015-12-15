using System.Web.Mvc;

namespace UnattendedTest.Controllers
{
    /// <summary>
    /// Class which models the home controller
    /// </summary>
    public class HomeController : Controller
    {
        // GET: /
        /// <summary>
        /// Returns the Index view
        /// </summary>
        /// <returns>A <see cref="ViewResult"/> object</returns>
        public ViewResult Index()
        {
            return View();
        }
    }
}