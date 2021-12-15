using MedShare.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

/* Idea: İnsanların ellerinde fazla kalan ilaçları paylaşabilmeleri için,
 * ilaç eklenen ve bireylerin ellerinde kaç adet o ilaçtan oldugunu ne kadar 
 * gönderebileceklerini yorumlayıp database e ekleyebildikleri bir sistem. 
 * 3 kutu simflatım var fazla diyip ekliyorum, elde 3 kutu var gözüküyor,
 * başka biri de buradan cekiyor mesela gibi. 
 * Her biri 3 kutu ekledikce database değişiyor. 
 */

namespace MedShare.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
