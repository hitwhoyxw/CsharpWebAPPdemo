using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;

namespace myWebApplication.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            string dataTime= DateTime.Now.ToString("d",new CultureInfo("zh-CN"));
            ViewData["TimeStamp"]= dataTime;
        }
    }

}
