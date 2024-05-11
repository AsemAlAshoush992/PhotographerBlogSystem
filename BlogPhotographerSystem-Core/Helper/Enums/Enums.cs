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
            None = 0,
            None2 = 1,
            None3 = 2,
        }
        public enum PaymentMethod
        {
            Cash = 0,
            OrangeMoney = 1,
            ZainCash = 2,
            EFawaTercom = 3,
            MasterCard = 4,
            Paypal = 5,
            CreditCard = 6,
        }
        public enum Status
        {
            Active = 0,
            Canceled = 1,
        }
    }
}
