using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ManagemenyShopify.WEB.Services;
using ManagemenyShopify.WEB.Models;
using ShopifySharp;
using ManagemenyShopify.WEB.Models;
using System.Xml;
using Newtonsoft.Json;
using System.IO;

namespace ManagemenyShopify.WEB.Controllers
{

    public class HomeController : Controller
    {
        
        const string MyShopifyUrl = "https://fashion-maverick-009.myshopify.com/";
        const string redirectUrl = "https://fashion-maverick-009.myshopify.com/admin/oauth/authorize";
        const string shopifyApiKey = "6bbfae03b9537d545dbd7ae2c6bd7ab3";
        const string shopifySecretKey = "ece45fea8a4177b72108121d7dfb428c";
        const string accessToken = "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";
        Service service = new Service(MyShopifyUrl, accessToken);
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public JsonResult PostTest([FromBody] string id)
        {
            return Json(id);
        }


        [HttpPost]
        public JsonResult GetOrder([FromBody] string id)    //получить информацию о заказе
        {
            if(service.GetOrder(Convert.ToInt32(id)) != null)
                return Json(service.GetOrder(Convert.ToInt32(id)));
            else
                return Json("Нет данных");            
        }


        [HttpPost]
        public JsonResult OrdersCount()    //получить количество заказов
        {
            return Json(service.OrdersCount());
        }

        [HttpPost]
        public JsonResult GetOrderById(int id)    //получить количество заказов
        {
            return Json(service.GetOrderById(id));
        }

        [HttpPost]
        public JsonResult DeleteOrder(int id)    //получить количество заказов
        {
            return Json(service.GetOrderById(id));
        }



        [HttpPost]
        public JsonResult CreateAddress()    //создаем заказ в shopisy и сохраняем его у себя в json
        {
            var model = new OrderTestModel();
            return Json(service.CreateOrder(model.OrderModel()));
        }


        [HttpPost]
        public JsonResult RebornOrder(int id)    //Воскрешаем заказ
        {
            var model = new OrderTestModel();
            return Json(service.RebornOrder(id));
        }

        [HttpPost]
        public JsonResult UpdateOrder(int orderId)    //Обновить заказ
        {
            var model = new OrderTestModel();
            return Json(service.UpdateOrder(orderId, model.OrderModel()));
        }

    }
}
