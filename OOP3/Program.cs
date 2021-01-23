using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacCreditManager ihtiyacCreditManager = new IhtiyacCreditManager();
            ICreditManager ihtiyacCreditManager = new IhtiyacCreditManager();
            ICreditManager tasitCreditManager = new TasitCreditManager();            
            ICreditManager konutCreditManager = new KonutCreditManager();

            ILoggerService dbLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();

            basvuruManager.BasvuruYap(konutCreditManager, new List<ILoggerService> { dbLoggerService, fileLoggerService });
            
            basvuruManager.BasvuruYap(konutCreditManager, new List<ILoggerService> { fileLoggerService });

            List<ICreditManager> credits = new List<ICreditManager>();
            credits.Add(ihtiyacCreditManager);
            credits.Add(tasitCreditManager);
            credits.Add(konutCreditManager);
            //basvuruManager.CreditInformation(credits);


        }
    }
}
