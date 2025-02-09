using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPhotographerSystem_Infra.Services
{
    public class OTPService
    {
        private readonly IMemoryCache _cache;

        public OTPService(IMemoryCache cache)
        {
            _cache = cache;
        }

        public string GenerateAndStoreOtp(string email)
        {
            string otp = GenerateOtp();
            // تخزين الـ OTP وربطه بالبريد الإلكتروني مع انتهاء الصلاحية بعد 10 دقائق
            _cache.Set(email, otp, TimeSpan.FromMinutes(10));
            return otp;
        }

        public bool ValidateOtp(string email, string otpCode)
        {
            // محاولة استرجاع OTP المخزن والتحقق من صحته
            if (_cache.TryGetValue(email, out string storedOtp) && storedOtp == otpCode)
            {
                // حذف OTP بعد التحقق الناجح
                _cache.Remove(email);
                return true;
            }
            return false;
        }

        private string GenerateOtp(int length = 6)
        {
            var random = new Random();
            var otp = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                otp.Append(random.Next(0, 10));
            }
            return otp.ToString();
        }
    }
}
