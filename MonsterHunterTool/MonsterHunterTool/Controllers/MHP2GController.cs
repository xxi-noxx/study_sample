using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MonsterHunterTool.Controllers
{
    public class MHP2GController : Controller
    {
        // GET: MHP2G
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// GET: ランダムQuest
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult RndQuest()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RndQuest(MonsterHunterTool.Models.MHP2G.RndQuest model)
        {

            return View();
        }
    }
}