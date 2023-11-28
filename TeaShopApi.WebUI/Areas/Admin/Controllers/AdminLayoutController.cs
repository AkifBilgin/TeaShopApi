using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace TeaShopApi.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }
		public PartialViewResult PartialSideBar()
		{
			return PartialView();
		}

		public PartialViewResult PartialNavbar()
		{
			return PartialView();
		}
	}
}
