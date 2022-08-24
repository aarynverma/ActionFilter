using Microsoft.AspNetCore.Mvc.Filters;

namespace ActionFilter
{
    public class MysampleActionFilterAttribute : Attribute, IActionFilter
    {
        private readonly string _name;
        public MysampleActionFilterAttribute(string name)
        {
            _name = name;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"OnActionExecuted - {_name}");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($"OnActionExecuting - {_name}");
        }
    }
}
