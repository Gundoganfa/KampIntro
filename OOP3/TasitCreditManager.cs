using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TasitCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Tasit kredisi odeme planı hesaplandı!");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
