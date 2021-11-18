using System; 
using Microsoft.AspNetCore.Mvc;

namespace luiz.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EscolaController : ControllerBase
    {
        [HttpGet]
        public Object Get()
        {
            return new {
                 nome = "ETEC Adolpho Berezin",
                 anoFundacao = 1995, 
                 cidade = "Mongaguá"

            };
        }
    }
}