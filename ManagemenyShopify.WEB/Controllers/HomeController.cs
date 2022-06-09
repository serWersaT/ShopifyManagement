using Microsoft.AspNetCore.Mvc;
using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagemenyShopify.WEB.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using ShopifySharp;
using Microsoft.Extensions.Primitives;
using System.Collections.Specialized;
using ShopifySharp.Enums;

namespace ManagemenyShopify.WEB.Controllers
{
    public static class Extensions
    {
        public static List<KeyValuePair<string, StringValues>> ToKvps(this System.Collections.Specialized.NameValueCollection qs)
        {
            Dictionary<string, string> parameters = qs.Keys.Cast<string>().ToDictionary(key => key, value => qs[value]);
            var kvps = new List<KeyValuePair<string, StringValues>>();

            parameters.ToList().ForEach(x =>
            {
                kvps.Add(new KeyValuePair<string, StringValues>(x.Key, new StringValues(x.Value)));
            });

            return kvps;
        }



        public static IEnumerable<KeyValuePair<string, StringValues>> ToKVPairs(this NameValueCollection collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            return collection.Cast<string>().Select(key => new KeyValuePair<string, StringValues>(key, collection[key]));
        }
    }


    public class HomeController : Controller
    {
        Service service = new Service();

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public JsonResult PostTest()
        {
            return Json("test completed");
        }


        [HttpPost]
        public async Task<JsonResult> CheckAddress()
        {

            try
            {
                string MyShopifyUrl = "https://store-testing-com.myshopify.com/";
                string redirectUrl = "https://store-testing-com.myshopify.com/";

                string shopifyApiKey = "3ecce54a6685d4ff5b5fc41f67fbe3a4";
                string shopifySecretKey = "d3214f42a6428f5413a9336ad1918424";


                var service1 = new ProductService(MyShopifyUrl, "*Raider67451");
                var eee = Response.StatusCode;
                bool isValidDomain = await AuthorizationService.IsValidShopDomainAsync(MyShopifyUrl);  /*проверяет корректность адреса*/
                
                var scopes1 = new List<AuthorizationScope>()
                {
                    AuthorizationScope.ReadCustomers,
                    AuthorizationScope.WriteCustomers
                };

                var scopes2 = new List<string>()
                {
                 "read_customers",
                "write_customers"
                };

                Uri authUrl = AuthorizationService.BuildAuthorizationUrl(scopes1, MyShopifyUrl, shopifyApiKey, redirectUrl);

                string code = "33e7c58fa67c3892455b89003e7959e2";
                string code2 = authUrl.Query;
                string myShopifyUrl = Request.Query["shop"];

                //string accessToken = await AuthorizationService.Authorize(code, MyShopifyUrl, shopifyApiKey, shopifySecretKey);
                string accessToken = await AuthorizationService.Authorize("33e7c58fa67c3892455b89003e7959e2", MyShopifyUrl, "3ecce54a6685d4ff5b5fc41f67fbe3a4", "d3214f42a6428f5413a9336ad1918424");

                return Json(accessToken);
            }
            catch (Exception ex)
            {
                return Json("Error:" + ex.ToString());
            }

        }

    }
}
