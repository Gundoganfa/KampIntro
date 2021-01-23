using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method Injection
        public void BasvuruYap(ICreditManager creditManager, ILoggerService loggerService)
        {
            // Başvuran bilgilerini değerlendirme
            // başka başka şeyler

            // kredi hangi turde gelirde gelsin dogru kredinin calculate metodu çalışır
            creditManager.Calculate();
            loggerService.Log();
        }

        public void CreditInformation(List<ICreditManager> credits)
        {
            foreach (var item in credits)
            {
                item.Calculate();
            }
        }
    }
}
