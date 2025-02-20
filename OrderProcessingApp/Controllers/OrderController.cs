using Microsoft.AspNetCore.Mvc;
using OrderProcessingApp.Models;

namespace OrderProcessingApp.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ProcessOrder(Order order)
        {
            if (order.Amount >= 100 && order.CustomerType == "Loyal")
            {
                order.Discount = order.Amount * 0.10m;  
            }
            else
            {
                order.Discount = 0;
            }

            order.FinalAmount = order.Amount - order.Discount;
            return View("Result", order);
        }
    }
}
