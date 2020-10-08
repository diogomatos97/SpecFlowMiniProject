using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
{
    class AppConfigReader
    {
        public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
        public static readonly string ProductURL = ConfigurationManager.AppSettings["products_url"];
        public static readonly string CartUrl = ConfigurationManager.AppSettings["cart_url"];
        public static readonly string CheckoutStepOneUrl = ConfigurationManager.AppSettings["checkout_step_one"];
        public static readonly string CheckoutStepTwoUrl = ConfigurationManager.AppSettings["checkout_step_two"];
        public static readonly string ConfirmedOrder = ConfigurationManager.AppSettings["confirmed"];

    }
}
