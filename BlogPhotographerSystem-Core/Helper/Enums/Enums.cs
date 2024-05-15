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
            Percent=1,
            FixedAmount=2,
            BundleDiscount=3
        }
        public enum PaymentMethod
        {
            Cash = 0,
            OrangeMoney = 1,
            ZainCash = 2,
            efawaTeercom = 3,
            MasterCard = 4,
            Paypal = 5,
            CreditCard = 6,
            Cliq = 7,
        }
        public enum Status
        {
            Pending = 0,
            Confirmed = 1,
            Processing= 2,
            Delivered= 3,
            Completed= 4,
            Cancelled= 5
        }
    }
}
