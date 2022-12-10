using Microsoft.AspNetCore.Mvc;

namespace Shop.EndPoint.ViewComponents
{
    #region site header
    public class SiteHeaderViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("siteHeader");
        }
    }
    #endregion
    #region site footer
    public class SiteHeaderViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("siteFooter");
        }
    }
    #endregion
}
