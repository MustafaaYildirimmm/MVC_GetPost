using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCGetAndPost.Controllers
{
    public class NewController : Controller
    {
        // GET: New
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult login()
        {
            //post: son kullanicinin sayfadan dbye ya da bir dökümana veri gondermek ve sayfa uzerine girilen verileri yakalamak amacıyla kullanilir.

            //if (Request.HttpMethod == "POST")
            //{
            //    string userName = Request.Form.Get("txtKullaniciAdi");
            //    string userPassword = Request.Form.Get("txtSifre");
            //    ViewBag.Password = userPassword;
            //    ViewBag.userName = userName;
            //}

            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult login(FormCollection frm)
        {
            string userName = frm.Get("txtKullaniciAdi");
            string userPassword = frm.Get("txtSifre");
            ViewBag.Password = userPassword;
            ViewBag.userName = userName;
            return View();
        }
        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult GetMethod(string ID)
        {
            ViewBag.GetId = ID;
            return View();
        }
    }
}