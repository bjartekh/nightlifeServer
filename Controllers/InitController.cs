using Microsoft.AspNetCore.Mvc;

namespace nightlifeServer.Controllers
{
    public class InitController
    {


        public IActionResult Index()
        {

            return new OkResult();
        }


    }
}