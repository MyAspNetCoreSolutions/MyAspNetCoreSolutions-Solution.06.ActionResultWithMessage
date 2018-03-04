using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.DependencyInjection;

namespace Lotfi.Session06.CustomActionResult
{
    public class AlertDecoratorResult : IActionResult
    {
        public IActionResult actionResult;
        public string Type { get; }
        public string Title { get; }
        public string Body { get;}

        public AlertDecoratorResult(IActionResult actionResult, string type, string title, string body)
        {
            this.actionResult = actionResult;
            this.Type = type;
            this.Title = title;
            this.Body = body;
        }

        

        public async Task ExecuteResultAsync(ActionContext context)
        {
            var factory = context.HttpContext.RequestServices.GetService<ITempDataDictionaryFactory>();
            var tempData = factory.GetTempData(context.HttpContext);
            tempData["_alert.type"] = Type;
            tempData["_alert.title"] = Title;
            tempData["_alert.body"] = Body;

            await actionResult.ExecuteResultAsync(context);
        }
    }
}