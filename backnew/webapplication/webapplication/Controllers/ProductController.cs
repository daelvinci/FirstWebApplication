using Microsoft.AspNetCore.Mvc;

namespace webapplication.Controllers
{
    public class ProductController:Controller
    {
        public ContentResult Detail(int id)
        {
            return Content($" Id budur: {id}");
        }
    }
}
