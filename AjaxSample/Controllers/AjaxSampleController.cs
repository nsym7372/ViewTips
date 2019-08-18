using AjaxSample.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AjaxSample.Controllers
{
    public class AjaxSampleController : Controller
    {
        // GET: AjaxSample
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BooksIndex()
        {
            var books = new List<Book>()
            {
                new Book(){ ID = 1, Author = "みやたひろし", Title="ネットワーク・デザインパターン", Publication = new DateTime(2018, 1, 1)},
                new Book(){ID = 2, Author = "石川俊介", Title= "ベースプレイの極意", Publication= new DateTime(2017, 12, 30)},
                new Book(){ID = 3, Author = "野口啓代", Title = "ボルダリング 基本ムーブと攻略法", Publication = new DateTime(2016, 2, 3)}
            };


            return Content("サーバーサイドから取得した値");
        }
    }
}