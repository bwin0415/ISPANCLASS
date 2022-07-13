using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Customers2019.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

namespace Customers2019.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMemoryCache _cache;

        public HomeController(ILogger<HomeController> logger,IMemoryCache cache)
        {
            _logger = logger;
            _cache = cache;
        }

        string SesionKey = "SesionKey";
        string CacheKey = "CacheKey";
        string CookieKey = "CookieKey";

        public IActionResult Index()
        {
            HttpContext.Session.SetString(SesionKey, "SessionValue");
            MemoryCacheEntryOptions CacheOptions = new MemoryCacheEntryOptions();
            CacheOptions.SetSlidingExpiration(TimeSpan.FromSeconds(60)); //SetPriority優先順序
            _cache.Set(CacheKey, "CacheValue", CacheOptions);
            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddYears(1);
            options.HttpOnly = true;//一定要加
            options.Secure = true;//一定要加
            Response.Cookies.Append(CookieKey,"CookieValue",options);

            return View();
        }

        public IActionResult Privacy()
        {
            if(HttpContext.Session.Keys.Contains(SesionKey)) {
                string SessionValue = HttpContext.Session.GetString(SesionKey);
            }
            object CacheData;
            if (_cache.TryGetValue(CacheKey,out CacheData))
            {
                string CacheValue = Convert.ToString(CacheData);
            }
            string CookieValue =HttpContext.Request.Cookies[CookieKey];//Null
            return View();
        }
        public IActionResult Contact()
        {
            return View("ContactView");
        }
        /*
        [HttpPost]
        [ValidateAntiForgeryToken]
        public RedirectToActionResult Contact(string Name, string Email)
        {//接收POST 第一代 直接寫{Requset}不要學
         //第二代(string Name, string Email){}不要學
         //第三代(IFormcollection collection){}適合做在Multiple check box
         //第四代 (ContactModel cm){ }

            return RedirectToAction(nameof(Index));
        }*/
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public RedirectToActionResult Contact(IFormCollection collection)
        //{//接收POST 第一代 直接寫{Requset}不要學
        // //第二代(string Name, string Email){}不要學
        // //第三代(IFormcollection collection){}適合做在Multiple check box
        // //第四代 (ContactModel cm){ }
        //    foreach (string key in collection.Keys)
        //    {
        //        string val = collection[key];
        //    }
        //    return RedirectToAction(nameof(Index));
        //}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact([Bind ("Name, Email")] LoginViewModel cm)
            //白名單資料驗證法(列出要得)
        //黑名單資料驗證法(列出不要的)
        {//接收POST 第一代 直接寫{Requset}不要學
         //第二代(string Name, string Email){}不要學
         //第三代(IFormcollection collection){}適合做在Multiple check box
         //第四代 (ContactModel cm){ }
            if (ModelState.IsValid)
            {
                ViewBag.Name = cm.Name;
                ViewBag.Email = cm.Email;
                
            }
            return View();
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public RedirectToActionResult Contact([Bind("Name, Email")] LoginViewModel cm)
        ////白名單資料驗證法(列出要得)
        ////黑名單資料驗證法(列出不要的)
        //{//接收POST 第一代 直接寫{Requset}不要學
        // //第二代(string Name, string Email){}不要學
        // //第三代(IFormcollection collection){}適合做在Multiple check box
        // //第四代 (ContactModel cm){ }
        //    if (ModelState.IsValid)
        //    {
        //        TempData["Name"] = cm.Name;
        //        TempData["Email"] = cm.Email;

        //    }
        //    return RedirectToAction(nameof(Index));
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
