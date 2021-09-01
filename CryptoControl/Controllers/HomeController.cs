using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace CryptoControl.Controllers
{
    public class HomeController : Controller
    {
        private string openedPass = "İshak Alpfidan";
        private string closedPass = "AI8BmkEfy1BHB1oVpfzlySGSaT2Yb1Q/2g1u+Xo0T8Q8phiDj1vmG7nd3r9yEE1umA==";

        public ActionResult Index()
        {
            string salt = Crypto.GenerateSalt();

            string hash = Crypto.Hash(openedPass, algorithm: "md5");
            string sh1 = Crypto.SHA1(openedPass);
            string sh256 = Crypto.SHA256(openedPass); ;

            string result = Crypto.HashPassword(openedPass); ;
            Boolean control = Crypto.VerifyHashedPassword(closedPass, openedPass); ;

            return View();
        }
    }
}