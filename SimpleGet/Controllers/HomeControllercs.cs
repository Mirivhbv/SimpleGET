using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimpleGet.Controllers
{
    [ApiController]
    public class HomeControllercs
    {
        [Route("")]
        public async Task<IActionResult> Index()
        {
            return new OkResult();
        }

        [Route("/farid")]
        [HttpGet]
        public async Task<IActionResult> Farid()
        {
            return new OkResult();
        }
    }
}