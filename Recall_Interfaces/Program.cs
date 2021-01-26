using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recall_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }
    class Customer : IPerson
    {
       
    }
    class Student : IPerson
    {
    }
}
