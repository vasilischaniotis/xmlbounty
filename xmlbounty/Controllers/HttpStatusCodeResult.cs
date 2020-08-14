using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace xmlbounty.Controllers
{
    internal class HttpStatusCodeResult : IActionResult
    {
        private object oK;

        public HttpStatusCodeResult(object oK) {
            this.oK = oK;
        }

        public Task ExecuteResultAsync(ActionContext context) {
            throw new System.NotImplementedException();
        }
    }
}