using Microsoft.AspNetCore.Mvc.Razor;

namespace NackowskisMax.Mvc
{
    public abstract class CustomRazorPage<TModel> : RazorPage<TModel>
    {
        public string CurrentUser => User?.Identity?.Name;
        public bool IsAdmin => User?.IsInRole("Admin") ?? false;

        public string ToDecimalString(double value)
        {
            return value.ToString().Replace(",", ".");
        }
    }
}
