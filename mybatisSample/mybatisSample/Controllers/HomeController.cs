using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBatisNet.DataMapper;

namespace mybatisSample.Controllers
{
    public class HomeController : Controller
    {
        private ISqlMapper mapper = Mapper.Instance();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Mybatis()
        {
            IList<Categories> categories = mapper.QueryForList<Categories>("select_categories", null);

            Repeater1.DataSource = categories;

        }
    }
}