using System;

namespace GenericDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> dictionary = new MyDictionary<string, string>();
            dictionary.Add("Father", "Bora");
            dictionary.Add("Son1", "Alp");
            dictionary.Add("Son2", "Tuncay");
            dictionary.Add("Daughter1", "Jenny");

        }
    }
}
