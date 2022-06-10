using ShopifySharp;
using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopifySharp.Enums;
using ManagemenyShopify.WEB.Models;
using System.IO;
using Newtonsoft.Json;

namespace ManagemenyShopify.WEB.Services
{
    public class Service
    {
        string _MyShopifyUrl;
        string _accessToken;

        string jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DB\\jsondata.json");

        public Service(string MyShopifyUrl, string accessToken)
        {
            _MyShopifyUrl = MyShopifyUrl;
            _accessToken = accessToken;            
#if DEBUG
            jsonPath = @"D:\С# примеры\Работа\Shopify MVC\v1\ManagemenyShopify\DB\jsondata.json";
#endif
            
        }

        public async Task<IEnumerable<Order>> GetOrder(int id)
        {
            try
            {
                var service1 = new CustomerService(_MyShopifyUrl, _accessToken);
                IEnumerable<Order> orders = await service1.ListOrdersForCustomerAsync(Convert.ToInt32(id));
                return orders;
            }
            catch
            {
                return null;
            }
        }

        public async Task<Order> GetOrderById(int id)
        {
            try
            {
                var service3 = new OrderService(_MyShopifyUrl, _accessToken);
                return await service3.GetAsync(id);
            }
            catch
            {
                return null;
            }
        }

        public async Task<int> OrdersCount()
        {
            try
            {
                var service = new OrderService(_MyShopifyUrl, _accessToken);
                return await service.CountAsync();
            }
            catch
            {
                return 0;
            }
        }

        public async Task<string> DeleteOrder(int id)
        {
            try
            {
                var service = new OrderService(_MyShopifyUrl, _accessToken);
                await service.DeleteAsync(id);
                return "Заказ удален";
            }
            catch
            {
                return "Нет заказа с таким Id";
            }
        }


        private void SerializeOrder(Order order)
        {
            string jsonData = JsonConvert.SerializeObject(order, Newtonsoft.Json.Formatting.None);
            System.IO.File.WriteAllText(jsonPath, jsonData);
        }

        private Order DesirializeOrder()
        {
            using (StreamReader reader = new StreamReader(jsonPath))
            {
                string text = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<Order>(text);
            }
        }


        public async Task<string> CreateOrder(Order order)
        {
            try
            {
                SerializeOrder(order);
                //order = await orderService.CreateAsync(order);    /*закоммичено чтобы не захламлять список левых заказов. Проверено - работает*/

                return "Заказ успешно создан";
            }
            catch (Exception ex)
            {
                return "Error:" + ex.ToString();
            }
        }

        public async Task<string> RebornOrder(int id)
        {
            //входящий параметр id добавлен только для красоты. Будет использоваться потом когда будет реализован поиск по БД
            try
            {
                var orderService = new OrderService(_MyShopifyUrl, _accessToken);
                var order = await orderService.CreateAsync(DesirializeOrder());    /*закоммичено чтобы не захламлять список левых заказов. Проверено - работает*/
                return "Воскрешение выполнено";
            }
            catch (Exception ex)
            {
                return "Error:" + ex.ToString();
            }
        }

        public async Task<string> UpdateOrder(int orderId, Order order)
        {
            try
            {
                var saveorder = await GetOrderById(orderId);
                SerializeOrder(saveorder);  //сохраняем старую версию заказа

                var orderService = new OrderService(_MyShopifyUrl, _accessToken);
                var update = await orderService.UpdateAsync(orderId, order);    /*закоммичено чтобы не захламлять список левых заказов. Проверено - работает*/
                SerializeOrder(update);  //сохраняем новую версию заказа
                return "Обновлени выполнено";
            }
            catch (Exception ex)
            {
                return "Error:" + ex.ToString();
            }
        }
    }
}
