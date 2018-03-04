using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lotfi.Session06.CustomActionResult
{
    public static class AlertExtensions
    {
        public static IActionResult WithSuccess(this IActionResult actionResult,string title,string body)
        {
            return Alert(actionResult, "success", title, body);
        }
        public static IActionResult WithInfo(this IActionResult actionResult, string title, string body)
        {
            return Alert(actionResult, "info", title, body);
        }
        public static IActionResult WithWarning(this IActionResult actionResult, string title, string body)
        {
            return Alert(actionResult, "warning", title, body);
        }
        public static IActionResult WithDanger(this IActionResult actionResult, string title, string body)
        {
            return Alert(actionResult,"danger", title, body);
        }

        private static IActionResult Alert(IActionResult actionResult,string type, string title, string body)
        {
            return new AlertDecoratorResult(actionResult,type,title,body);
        }
    }
}
