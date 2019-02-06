using lab21.DAL;
using System.Linq;
using System.Web.Mvc;
namespace lab21.Controllers
{
	public class ProductController : Controller
	{

		// James - I like that you are using this as a private field, I would also make it readonly, you don't want to replace this reference by accident. 
		private ShopContext db = new ShopContext();
		// GET: Product
		public ActionResult Index()
		{


			return View(db.Item.ToList());

		}
	}
}