﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutCreditManager : ICreditManager
    {
        // Creditmanager içindeki calculate metodunu kullanabilir hale geldi
        public void Calculate()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı!");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
