using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Core.Helper.Enums
{
    public class Enums
    {
       public enum DiscountType{
            Percent,
            FixedAmount,
            BundleDiscount
        }
        public enum PaymentMethod
        {
            Cash,
            OrangeMoney,
            ZainCash,
            efawaTeercom,
            MasterCard,
            Paypal,
            CreditCard,
            Cliq,
        }
        public enum Status
        {
            Pending,
            Confirmed,
            Processing,
            Delivered,
            Completed,
            Cancelled
        }
        public enum UserType
        {
            Client,
            Admin
        }
        public enum FileType
        {
            Image,
            Video,
            Document
        }
    }
}
