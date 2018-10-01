using NLog;
using SomeLibrary;
using System.Web.Http;

namespace SomeWebapi.Controllers
{
    [RoutePrefix("api/home")]
    public class HomeController : ApiController
    {
        private Logger _logger = LogManager.GetCurrentClassLogger();

        [HttpGet]
        [Route("index")]
        public string Index()
        {
            _logger.Info("Index called");
            return "Index";
        }

        [HttpGet]
        [Route("say")]
        public string Say()
        {
            var instance = new SomeClass();
            return instance.Say();
        }
    }
}
