using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AppleWalletServerDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppleWalletController : ControllerBase
    {
        // GET
        [HttpGet]
        public async Task<ActionResult<byte[]>> GetAsync()
        {
            var passPath = "./Passes/Generic.pkpass";

            var pkpassFileFileBytes = await System.IO.File.ReadAllBytesAsync(passPath);
            
            return new FileContentResult(pkpassFileFileBytes, "application/vnd.apple.pkpass");
        }
    }
}