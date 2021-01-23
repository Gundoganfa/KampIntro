using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method Injection
        public void BasvuruYap(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            // Başvuran bilgilerini değerlendirme
            // başka başka şeyler

            // kredi hangi turde gelirde gelsin dogru kredinin calculate metodu çalışır
            creditManager.Calculate();
            foreach (var item in loggerServices)
            {
                item.Log();
            }
            
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
