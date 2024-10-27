using Microsoft.AspNetCore.Mvc;

namespace GR30323WEB_Zhelobkovich.UI.ViewComponents
{
    public class CartViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            return View(); 
        }

    }
}
